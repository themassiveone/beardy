

public class BeardyArgumentsNonVerified
{
    public string? action { get; set; }
    public string? subject { get; set; }
    public Dictionary<string, string> keyValuePairs { get; set; }


}

public class BeardyArgumentsVerified
{
    public BeardyArgumentsVerified(BeardyArgumentsNonVerified nonVerified)
    {
        if (nonVerified.action is not null)
            this.action = nonVerified.action;

        if (nonVerified.subject is not null)
            this.subject = nonVerified.subject;

        this.keyValuePairs = nonVerified.keyValuePairs;
    }
    public string action { get; set; }
    public string subject { get; set; }
    public Dictionary<string, string> keyValuePairs { get; set; }
}