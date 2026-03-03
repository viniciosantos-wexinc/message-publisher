using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MessagePublisher.Models;

[DataContract(Name = nameof(ElectionChangeDetected), Namespace = "wex.health.be.benefits")]
public record ElectionChangeDetected
{
    [DataMember(Name = "user_id")]
    public long UserId { get; set; }

    [DataMember(Name = "parent_user_id")]
    public long? ParentUserId { get; set; }

    [DataMember(Name = "benefit_election_id")]
    public long BenefitElectionId { get; set; }

    [DataMember(Name = "change_type_description")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ChangeType ChangeType { get; set; }

    [DataMember(Name = "is_expanded")]
    public bool IsExpanded { get; set; }
}