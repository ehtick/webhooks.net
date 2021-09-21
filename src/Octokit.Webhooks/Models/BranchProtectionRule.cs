﻿namespace Octokit.Webhooks.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record BranchProtectionRule
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("repository_id")]
        public int RepositoryId { get; init; }

        [JsonPropertyName("name")]
        public string Name { get; init; } = null!;

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; init; } = null!;

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; init; } = null!;

        [JsonPropertyName("admin_enforced")]
        public bool AdminEnforced { get; init; }

        [JsonPropertyName("allow_deletions_enforcement_level")]
        public EnforcementLevel AllowDeletionsEnforcementLevel { get; init; }

        [JsonPropertyName("allow_force_pushes_enforcement_level")]
        public EnforcementLevel AllowForcePushesEnforcementLevel { get; init; }

        [JsonPropertyName("authorized_actor_names")]
        public IEnumerable<string> AuthorizedActorNames { get; init; } = null!;

        [JsonPropertyName("authorized_actors_only")]
        public bool AuthorizedActorsOnly { get; init; }

        [JsonPropertyName("authorized_dismissal_actors_only")]
        public bool AuthorizedDismissalActorsOnly { get; init; }

        [JsonPropertyName("dismiss_stale_reviews_on_push")]
        public bool DismissStaleReviewsOnPush { get; init; }

        [JsonPropertyName("ignore_approvals_from_contributors")]
        public bool IgnoreApprovalsFromContributors { get; init; }

        [JsonPropertyName("linear_history_requirement_enforcement_level")]
        public EnforcementLevel LinearHistoryRequirementEnforcementLevel { get; init; }

        [JsonPropertyName("merge_queue_enforcement_level")]
        public EnforcementLevel MergeQueueEnforcementLevel { get; init; }

        [JsonPropertyName("pull_request_reviews_enforcement_level")]
        public EnforcementLevel PullRequestReviewsEnforcementLevel { get; init; }

        [JsonPropertyName("require_code_owner_review")]
        public bool RequireCodeOwnerReview { get; init; }

        [JsonPropertyName("required_approving_review_count")]
        public int RequiredApprovingReviewCount { get; init; }

        [JsonPropertyName("required_conversation_resolution_level")]
        public EnforcementLevel RequiredConversationResolutionLevel { get; init; }

        [JsonPropertyName("required_deployments_enforcement_level")]
        public EnforcementLevel RequiredDeploymentsEnforcementLevel { get; init; }

        [JsonPropertyName("required_status_checks")]
        public IEnumerable<string> RequiredStatusChecks { get; init; } = null!;

        [JsonPropertyName("required_status_checks_enforcement_level")]
        public EnforcementLevel RequiredStatusChecksEnforcementLevel { get; init; }

        [JsonPropertyName("signature_requirement_enforcement_level")]
        public EnforcementLevel SignatureRequirementEnforcementLevel { get; init; }

        [JsonPropertyName("strict_required_status_checks_policy")]
        public bool StrictRequiredStatusChecksPolicy { get; init; }
    }
}
