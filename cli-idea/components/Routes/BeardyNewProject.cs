public class BeardyNewProject : BeardyBase
{



    public override void Main() => Branch();

    protected override void PassOnTo(BeardyMapper mapper)
    {
        mapper.Map(x =>)
    }

    protected override void Verify(BeardyArgumentVerificator verificator)
    {
        verificator.RequireArgument(x => x.keyValuePairs.Where(y => y.Key == "template").First());
    }
}