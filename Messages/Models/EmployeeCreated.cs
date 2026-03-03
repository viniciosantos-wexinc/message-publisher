using System.Runtime.Serialization;

namespace Messages.Models;

[DataContract(Name = nameof(EmployeeCreated), Namespace = "EmployeeDataStream.Models.Kafka")]
public record EmployeeCreated
{
    [DataMember(Name = "user_id")]
    public int user_id { get; set; }

    [DataMember(Name = "client_id")]
    public int client_id { get; set; }

    [DataMember(Name = "origin")]
    public EmployeeCreatedType origin { get; set; }

    [DataMember(Name = "reclaim_batch_id")]
    public int? reclaim_batch_id { get; set; }

    public override string ToString() =>
        $"UID: {user_id}, CID: {client_id}";
}