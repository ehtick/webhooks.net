﻿namespace JamieMagee.Octokit.Webhooks.Models
{
    using System.Text.Json.Serialization;

    public sealed record RepoRef
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; init; } = null!;
    }
}