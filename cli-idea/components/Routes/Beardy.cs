using Stubble.Core.Builders;




public class Beardy : BeardyBase
{

    public void Old()
    {
        return;


        var header = $"Analysing directory: {Environment.CurrentDirectory}";
        Terminal.WriteLine(header);
        Terminal.WriteLine(header.Length.ForEachDisplay(x => "="));


        string templatePath = "/mnt/Project/ProjectManager/apiTemplate";
        if (Directory.Exists(templatePath))
        {

            var stubble = new StubbleBuilder().Build();
            DirectoryOperation.ForeachPathRecurse(templatePath + "/", x =>
            {
                Terminal.WriteLine("");

                var templateContent = File.ReadAllText(x);

                var relativePath = x.Replace(templatePath, "").Remove(0, 1);
                var newFullPath = Path.Combine(Environment.CurrentDirectory, relativePath);


                // Ensure new path exists
                var parts = x.Split("/").ToList();
                parts.Remove(parts.Last());
                var relativePathDirectoryOnly = string.Join("/", parts).Replace(templatePath, "").TrimStart('/');
                var ensuredPath = Path.Combine(Environment.CurrentDirectory, relativePathDirectoryOnly);
                if (ensuredPath != Environment.CurrentDirectory && !Directory.Exists(ensuredPath))
                {
                    Terminal.WriteLine($"Create Path : ${ensuredPath}");
                    Directory.CreateDirectory(ensuredPath);
                }


                if (x.Contains(".mustache"))
                {
                    var announcement = $"Template found: {relativePath}";
                    Terminal.WriteLine(announcement, ConsoleColor.Cyan);
                    // Terminal.Write(announcement.Length.ForEachDisplay(x => "="));



                    // Terminal.Write(content);

                }
                else
                {
                    var announcement = $"Normal file found found: {relativePath}";
                    Terminal.WriteLine(announcement, ConsoleColor.Green);
                    // Terminal.Write(announcement.Length.ForEachDisplay(x => "="));

                    if (File.Exists(newFullPath))
                    {
                        Terminal.WriteLine("file conflict", ConsoleColor.Red);
                    }
                    File.WriteAllText(newFullPath, templateContent);


                }
            });
        }








    }

    public override void Main() => Branch();

    protected override void PassOnTo(BeardyMapper mapper)
    {
        mapper.Map(x => x.action == "new").To<BeardyNew>().Describe("Create a new Project from a template");
        mapper.Map(x => x.action == "update").To<BeardyUpdate>().Describe("Update the generateble files inside a project");
    }

    protected override void Verify(BeardyArgumentVerificator verificator)
    {
        verificator.RequireArgument(x => x.action);
    }
}