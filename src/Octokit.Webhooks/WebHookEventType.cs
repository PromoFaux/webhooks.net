﻿namespace Octokit.Webhooks
{
    public static class WebhookEventType
    {
        public const string BranchProtectionRule = "branch_protection_rule";
        public const string CheckRun = "check_run";
        public const string CheckSuite = "check_suite";
        public const string CodeScanningAlert = "code_scanning_alert";
        public const string CommitComment = "commit_comment";
        public const string ContentReference = "content_reference";
        public const string Create = "create";
        public const string Delete = "delete";
        public const string Deployment = "deployment";
        public const string DeploymentReview = "deployment_review";
        public const string DeploymentStatus = "deployment_status";
        public const string DeployKey = "deploy_key";
        public const string Discussion = "discussion";
        public const string DiscussionComment = "discussion_comment";
        public const string Fork = "fork";
        public const string GithubAppAuthorization = "github_app_authorization";
        public const string Gollum = "gollum";
        public const string Installation = "installation";
        public const string InstallationRepositories = "installation_repositories";
        public const string Issues = "issues";
        public const string IssueComment = "issue_comment";
        public const string Label = "label";
        public const string MarketplacePurchase = "marketplace_purchase";
        public const string Member = "member";
        public const string Membership = "membership";
        public const string Meta = "meta";
        public const string Milestone = "milestone";
        public const string Organization = "organization";
        public const string OrgBlock = "org_block";
        public const string Package = "package";
        public const string PageBuild = "page_build";
        public const string Ping = "ping";
        public const string Project = "project";
        public const string ProjectCard = "project_card";
        public const string ProjectColumn = "project_column";
        public const string Public = "public";
        public const string PullRequest = "pull_request";
        public const string PullRequestReview = "pull_request_review";
        public const string PullRequestReviewComment = "pull_request_review_comment";
        public const string Push = "push";
        public const string RegistryPackage = "registry_package";
        public const string Release = "release";
        public const string Repository = "repository";
        public const string RepositoryDispatch = "repository_dispatch";
        public const string RepositoryImport = "repository_import";
        public const string RepositoryVulnerabilityAlert = "repository_vulnerability_alert";
        public const string SecretScanningAlert = "secret_scanning_alert";
        public const string SecurityAdvisory = "security_advisory";
        public const string Sponsorship = "sponsorship";
        public const string Star = "star";
        public const string Status = "status";
        public const string Team = "team";
        public const string TeamAdd = "team_add";
        public const string Watch = "watch";
        public const string WorkflowDispatch = "workflow_dispatch";
        public const string WorkflowJob = "workflow_job";
        public const string WorkflowRun = "workflow_run";
    }
}