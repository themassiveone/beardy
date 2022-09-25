
public class BeardyMapperDelegateResult
{
    private Func<BeardyArgumentsVerified, bool> from { get; set; }
    private Action<Func<BeardyArgumentsVerified, bool>, BeardyBase> adder { get; set; }
    private Action<Func<BeardyArgumentsVerified, bool>, string> descriptor { get; set; }
    public BeardyMapperDelegateResult(Func<BeardyArgumentsVerified, bool> from, Action<Func<BeardyArgumentsVerified, bool>, BeardyBase> adder, Action<Func<BeardyArgumentsVerified, bool>, string> descriptor)
    {
        this.from = from;
        this.adder = adder;
        this.descriptor = descriptor;
    }

    public BeardyMapperDescriptor To<T>()
    where T : BeardyBase, new()
    {
        adder(from, new T());
        return new BeardyMapperDescriptor(from, descriptor);
    }

}

