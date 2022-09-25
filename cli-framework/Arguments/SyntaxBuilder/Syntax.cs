public class Syntax
{

    private List<SyntaxElement> syntaxElements = new List<SyntaxElement>();

    public SyntaxArgument AddMandatoryArgument(string argument)
    {
        var syntaxArgument = new SyntaxArgument(argument);
        syntaxElements.Add(syntaxArgument);
        return syntaxArgument;
    }

    public SyntaxOptions AddOptions()
    {
        var options = new SyntaxOptions();
        syntaxElements.Add(options;)
    }

    public void AddBranch<T>()
    where T : Branch, new()
    {
        syntaxElements.Add(new SyntaxBranch(new T()));
    }



}


public abstract class SyntaxElement
{

}

public class SyntaxBranch : SyntaxElement
{
    private Branch branch;
    public SyntaxBranch(Branch branch)
    {
        this.branch = branch;
    }
}


public class SyntaxArgument : SyntaxElement
{
    private string name;
    public SyntaxArgument(string name)
    {
        this.name = name;
    }
}

public class SyntaxOptions : SyntaxElement
{

}