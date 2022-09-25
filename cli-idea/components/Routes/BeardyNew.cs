
public class BeardyNew : BeardyBase
{


    public override void Main() => Branch();

    protected override void PassOnTo(BeardyMapper mapper)
    {
        mapper.Map(x => x.subject == "project").To<BeardyNewProject>().Describe("Create a new Project");
    }

    protected override void Verify(BeardyArgumentVerificator verificator)
    {
        verificator.RequireArgument(x => x.subject);
    }
}