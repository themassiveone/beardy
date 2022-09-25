
using Microsoft.Extensions.Configuration;

public abstract class BeardyBase
{




    public BeardyArgumentsVerified arguments { get; set; }
    private BeardyArgumentsNonVerified nonVerified { get; set; }

    private BeardyMappings mappings { get; set; } = new BeardyMappings();
    public BeardyBase()
    {
        this.nonVerified = ArgumentPublication.argumentBase.Receive();
        PassOnTo(new BeardyMapper(mappings));
    }





    public abstract void Main();
    public void Start()
    {
        BeardyArgumentVerificator verificator = new BeardyArgumentVerificator(nonVerified);
        Verify(verificator);
        if (!verificator.Validate())
        {
            Help();
            return;
        }
        arguments = new BeardyArgumentsVerified(nonVerified);

        Main();
    }






    protected abstract void Verify(BeardyArgumentVerificator verificator);


    protected virtual void Help()
    {
        Terminal.WriteLine("You need to pass one of These argument:");
        Terminal.WriteLine("");
        Terminal.WriteLine("Options:");

        foreach (var mapping in mappings.mappings)
        {
            Terminal.Write($"{"",4}{mapping.Key}", ConsoleColor.Green);

            foreach (var description in mappings.descriptions)
            {
                if (description.Key != mapping.Key)
                    continue;
                Terminal.Write($"{"",8}{description.Value}");
            }
            Terminal.WriteLine("");
        }

    }

    protected void Branch()
    {
        foreach (var mapping in mappings.mappings)
        {
            if (mapping.Key(arguments))
            {
                mapping.Value.Start();
                return;
            }

            Terminal.WriteLine("Argument does not exist", ConsoleColor.Red);
        }
    }





    protected abstract void PassOnTo(BeardyMapper mapper);
}
