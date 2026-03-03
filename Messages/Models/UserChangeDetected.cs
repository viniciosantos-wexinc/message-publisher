using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Messages.Models;

[DataContract(Name = nameof(UserChangeDetected), Namespace = "wex.health.be.benefits")]
public record UserChangeDetected
{
    [DataMember(Name = "user_id")]
    public long UserId { get; set; }

    [DataMember(Name = "plan_type_id")]
    public int[] PlanTypeIDs { get; set; } = [];

    [DataMember(Name = "change_type_description")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ChangeType ChangeType { get; set; }

    public override string ToString() =>
        $"UserChangeDetected {{ UserId: {UserId}, PlanTypeIDs: [{string.Join(", ", PlanTypeIDs)}], ChangeType: {ChangeType} }}";
}