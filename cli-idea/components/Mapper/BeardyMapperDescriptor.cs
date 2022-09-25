
public class BeardyMapperDescriptor
{
    private Func<BeardyArgumentsVerified, bool> from { get; set; }
    private Action<Func<BeardyArgumentsVerified, bool>, string> descriptor { get; set; }
    public BeardyMapperDescriptor(Func<BeardyArgumentsVerified, bool> from, Action<Func<BeardyArgumentsVerified, bool>, string> descriptor)
    {
        this.from = from;
        this.descriptor = descriptor;
    }
    public void Describe(string description)
    {
        descriptor(from, description);
    }
}
