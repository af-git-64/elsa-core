using Elsa.Common.Models;
using Elsa.Workflows.Management.Entities;

namespace Elsa.Workflows.Management.Services;

public interface IWorkflowDefinitionPublisher
{
    WorkflowDefinition New();
    Task<WorkflowDefinition?> PublishAsync(string definitionId, CancellationToken cancellationToken = default);
    Task<WorkflowDefinition> PublishAsync(WorkflowDefinition definition, CancellationToken cancellationToken = default);
    Task<WorkflowDefinition?> RetractAsync(string definitionId, CancellationToken cancellationToken = default);
    Task<WorkflowDefinition> RetractAsync(WorkflowDefinition definition, CancellationToken cancellationToken = default);
    Task<WorkflowDefinition?> GetDraftAsync(string definitionId, VersionOptions versionOptions, CancellationToken cancellationToken = default);
    Task<WorkflowDefinition> SaveDraftAsync(WorkflowDefinition definition, CancellationToken cancellationToken = default);
}