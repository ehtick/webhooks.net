﻿namespace JamieMagee.Octokit.Webhooks.Models
{
    using System.Text.Json.Serialization;

    public class PackageRegistry
    {
        [JsonPropertyName("about_url")]
        public string AboutUrl { get; init; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; init; } = null!;

        [JsonPropertyName("type")]
        public string Type { get; init; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("vendor")]
        public string Vendor { get; init; } = null!;
    }
}
