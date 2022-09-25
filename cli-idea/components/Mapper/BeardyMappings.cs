public class BeardyMappings
{
    public Dictionary<Func<BeardyArgumentsVerified, bool>, BeardyBase> mappings { get; set; } = new Dictionary<Func<BeardyArgumentsVerified, bool>, BeardyBase>();
    public Dictionary<Func<BeardyArgumentsVerified, bool>, string> descriptions { get; set; } = new Dictionary<Func<BeardyArgumentsVerified, bool>, string>();
}