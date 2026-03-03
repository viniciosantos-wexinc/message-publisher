namespace Messages.Settings;

public record Message(
    string Topic,
    string SchemaFile,
    string SchemaSubject
)
{
    public string GetSchemaPath()
    {
        var schemaPath = Path.Combine(AppContext.BaseDirectory, "schemas");
        var path = Path.Combine(schemaPath, SchemaFile);

        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Schema file not found: {path}");
        }

        return path;
    }
};