
public static class ArgumentPublication
{
    public static ArgumentBase argumentBase;
}

public abstract class ArgumentBase
{
    public abstract BeardyArgumentsNonVerified Receive();
}

public class ArgumentParser : ArgumentBase
{
    public override BeardyArgumentsNonVerified Receive()
    {
        var args = Environment.GetCommandLineArgs();
        BeardyArgumentsNonVerified beardyArguments = new BeardyArgumentsNonVerified();
        if (args.Length >= 2)
            beardyArguments.action = args[1];
        if (args.Length >= 3)
            beardyArguments.subject = args[2];

        beardyArguments.keyValuePairs = GetKeyValue(new List<string>(){
            "template",
            "project"

        }, args);

        return beardyArguments;
    }


    private Dictionary<string, string> GetKeyValue(List<string> options, string[] args)
    {
        var dictionary = new Dictionary<string, string>();
        foreach (var option in options)
        {
            if (!args.Contains(option))
                continue;
            int searchIndex = 0;
            int index = 0;
            foreach (var item in args)
            {
                if (item == option)
                {
                    searchIndex = index + 1;
                    break;
                }
            }
            if (searchIndex == 0)
                return null;
            if (args.Length - 1 <= searchIndex)
                return null;

            dictionary.Add(option, args[searchIndex]);
        }
        return dictionary;
    }

}