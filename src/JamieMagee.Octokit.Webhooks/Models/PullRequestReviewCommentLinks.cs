﻿namespace JamieMagee.Octokit.Webhooks.Models
{
    using System.Text.Json.Serialization;

    public class PullRequestReviewCommentLinks
    {
        [JsonPropertyName("self")]
        public Link Self { get; init; } = null!;
        [JsonPropertyName("html")]
        public Link Html { get; init; } = null!;
        [JsonPropertyName("pull_request")]
        public Link PullRequest { get; init; } = null!;
    }
}
