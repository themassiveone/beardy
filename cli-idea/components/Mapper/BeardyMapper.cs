

public class BeardyMapper
{
    private BeardyMappings mappings { get; set; }
    public BeardyMapper(BeardyMappings mappings)
    {
        this.mappings = mappings;
    }


    public BeardyMapperDelegateResult Map(Func<BeardyArgumentsVerified, bool> from)
    {
        return new BeardyMapperDelegateResult(from, mappings.mappings.Add, mappings.descriptions.Add);
    }
    public BeardyMapperDelegateResult Map(string key)
    {
        return new BeardyMapperResult(key, mappings.mappings.Add, mappings.descriptions.Add);
    }

    public

}

