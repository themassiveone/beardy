using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TemplateController : ControllerBase
{
    private string templatesPath { get; set; }
    public TemplateController(IConfiguration config)
    {
        templatesPath = config.GetSection("templatesPath").Value;
    }


    [HttpGet("files/{templateName}")]
    public ActionResult<IEnumerable<string>> GetFilePaths(string templateName)
    {
        var templatePath = Path.Combine(templatesPath, templateName);

        if (!DirectoryOperation.Contains(templatesPath, templatePath))
            BadRequest("Security violation");


        if (!System.IO.File.Exists(templatePath))
            BadRequest("template doesnt exist");


        List<string> paths = new List<string>();
        DirectoryOperation.ForeachPathRecurse(templatePath, x =>
        {
            paths.Add(x.Replace(templatesPath, "").TrimStart('/'));
        });
        return Ok(paths);
    }

    [HttpGet("file/{filePath}")]
    public ActionResult<string> GetFileContents(string filePath)
    {
        filePath = filePath.Replace("%2F", "/");
        var fileFullPath = Path.Combine(templatesPath, filePath);
        Console.WriteLine(fileFullPath);
        if (!DirectoryOperation.Contains(templatesPath, fileFullPath))
            return BadRequest("Security violation");

        if (!System.IO.File.Exists(fileFullPath))
            return BadRequest("file does not exist");

        return Ok(System.IO.File.ReadAllText(fileFullPath));

    }
}