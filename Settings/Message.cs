namespace MessagePublisher.Settings;

public record Message(
    string Topic,
    string SchemaFile,
    string SchemaSubject
)
{
    public string GetSchemaPath()
    {
        var path = Path.Combine("schemas", SchemaFile);

        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Schema file not found: {path}");
        }

        return path;
    }
};