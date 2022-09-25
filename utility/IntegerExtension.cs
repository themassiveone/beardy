using System.Text;

public static class IntegerExtension
{
    public static string ForEachDisplay(this int value, Func<int, string> action)
    {
        var builder = new StringBuilder();

        if (value > 0)
        {
            for (int i = 0; i < value; i++)
            {
                builder.Append(action(i));
            }
        }
        else if (value < 0)
        {
            for (int i = value - 1; i >= 0; i--)
            {
                builder.Append(action(i));
            }
        }
        return builder.ToString();
    }
}