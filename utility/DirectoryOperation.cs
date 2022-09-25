public static class DirectoryOperation
{
    public static void ForeachPathRecurse(string path, Action<string> operation)
    {
        foreach (string f in Directory.GetFiles(path))
        {
            operation(f);
        }

        foreach (string d in Directory.GetDirectories(path))
        {
            ForeachPathRecurse(d, operation);
        }

    }

    public static bool Contains(string parent, string path)
    {
        var allFiles = Directory.GetFiles(parent, "*.*", SearchOption.AllDirectories);
        if (allFiles.Contains(path))
            return true;
        return false;
    }
}