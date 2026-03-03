namespace Messages.Settings;

public record Kafka(
    string BootstrapServers,
    string SecurityProtocol,
    string SslCaPem,
    string SslCertificatePem,
    string SslKeyPem,
    SchemaRegistrySettings SchemaRegistry
);

public record SchemaRegistrySettings(
    string Url,
    string UserName,
    string Password
);