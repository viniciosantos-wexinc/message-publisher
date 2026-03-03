using Microsoft.Extensions.DependencyInjection;
using Wex.Libraries.Kafka;
using Wex.Libraries.Kafka.Producer;

namespace MessagePublisher;

public static class Publisher
{
    public static async Task PublishFromAsync<T>(IServiceScope scope, string topic, T message, string? IdempotencyKey = null)
    {
        var service = scope.ServiceProvider.GetRequiredService<IKafkaProducer<T>>();

        try
        {
            await service.ProduceAsync(
                topic,
                Guid.NewGuid().ToString(),
                new Message<T>(IdempotencyKey ?? Guid.NewGuid().ToString(), message),
                CancellationToken.None
            );

            Console.WriteLine($"Message produced: {message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to produce message: {ex.Message}");
        }
    }
}