﻿namespace Octokit.Webhooks.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record Issue
    {
        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("repository_url")]
        public string RepositoryUrl { get; init; } = null!;

        [JsonPropertyName("labels_url")]
        public string LabelsUrl { get; init; } = null!;

        [JsonPropertyName("comments_url")]
        public string CommentsUrl { get; init; } = null!;

        [JsonPropertyName("events_url")]
        public string EventsUrl { get; init; } = null!;

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; init; } = null!;

        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("node_id")]
        public string NodeId { get; init; } = null!;

        [JsonPropertyName("number")]
        public int Number { get; init; }

        [JsonPropertyName("title")]
        public string Title { get; init; } = null!;

        [JsonPropertyName("user")]
        public User User { get; init; } = null!;

        [JsonPropertyName("labels")]
        public IEnumerable<Label> Labels { get; init; } = null!;

        [JsonPropertyName("state")]
        public IssueState? State { get; init; }

        [JsonPropertyName("locked")]
        public bool? Locked { get; init; }

        [JsonPropertyName("assignee")]
        public User? Assignee { get; init; }

        [JsonPropertyName("assignees")]
        public IEnumerable<User> Assignees { get; init; } = null!;

        [JsonPropertyName("milestone")]
        public Milestone? Milestone { get; init; }

        [JsonPropertyName("comments")]
        public int Comments { get; init; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; init; } = null!;

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; init; } = null!;

        [JsonPropertyName("closed_at")]
        public string? ClosedAt { get; init; }

        [JsonPropertyName("author_association")]
        public AuthorAssociation AuthorAssociation { get; init; }

        [JsonPropertyName("active_lock_reason")]
        public ActiveLockReason? ActiveLockReason { get; init; }

        [JsonPropertyName("performed_via_github_app")]
        public App? PerformedViaGithubApp { get; init; }

        [JsonPropertyName("pull_request")]
        public IssuePullRequest PullRequest { get; init; } = null!;

        [JsonPropertyName("body")]
        public string? Body { get; init; }
    }
}