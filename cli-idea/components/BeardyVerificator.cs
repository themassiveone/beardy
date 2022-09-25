public class BeardyArgumentVerificator
{
    private BeardyArgumentsNonVerified arguments { get; set; }
    public BeardyArgumentVerificator(BeardyArgumentsNonVerified arguments)
    {
        this.arguments = arguments;
    }
    public bool Validate()
    {
        foreach (var requirement in argumentRequirements)
        {
            if (requirement(arguments) is null)
                return false;
        }

        foreach (var requirement in keyValueRequirements)
        {
            var result = requirement(arguments);
            if (result is null)
                return false;
        }

        return true;
    }
    private List<Func<BeardyArgumentsNonVerified, string?>> argumentRequirements = new List<Func<BeardyArgumentsNonVerified, string?>>();
    private List<Func<BeardyArgumentsNonVerified, KeyValuePair<string, string>?>> keyValueRequirements = new List<Func<BeardyArgumentsNonVerified, KeyValuePair<string, string>?>>();

    public void RequireArgument(Func<BeardyArgumentsNonVerified, string?> accessor)
    {
        argumentRequirements.Add(accessor);
    }

    public void RequireArgument(Func<BeardyArgumentsNonVerified, KeyValuePair<string, string>?> accessor)
    {
        keyValueRequirements.Add(accessor);
    }




}
