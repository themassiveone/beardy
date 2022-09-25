public class BeardyNewProjectTemplate : BeardyBase
{

    private void Template()
    {
        var templateName = arguments.keyValuePairs.Value;

        var url = "$$$";
        Console.WriteLine(url);
        var wrapper = new HttpClientWrapper();
        var result = wrapper.GetJson<IEnumerable<string>>(url);

        Console.WriteLine("test");

        Terminal.WriteLine(string.Join("\r\n", result));





    }

    public override void Main()
    {
    }

    protected override void PassOnTo(BeardyMapper mapper)
    {
    }

    protected override void Verify(BeardyArgumentVerificator verificator)
    {
        // verificator
    }
}