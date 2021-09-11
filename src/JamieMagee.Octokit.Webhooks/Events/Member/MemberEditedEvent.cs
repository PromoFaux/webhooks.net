namespace JamieMagee.Octokit.Webhooks.Events.Member
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    public sealed record MemberEditedEvent : MemberEvent
    {
        [JsonPropertyName("action")]
        public override string Action => MemberAction.Edited;
    }
}