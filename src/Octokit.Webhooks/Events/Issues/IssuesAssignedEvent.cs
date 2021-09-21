namespace Octokit.Webhooks.Events.Issues
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;
    using Octokit.Webhooks.Models;

    [PublicAPI]
    [WebhookActionType(IssuesActionValue.Assigned)]
    public sealed record IssuesAssignedEvent : IssuesEvent
    {
        [JsonPropertyName("action")]
        public override string Action => IssuesAction.Assigned;

        [JsonPropertyName("assignee")]
        public User? Assignee { get; init; }
    }
}
