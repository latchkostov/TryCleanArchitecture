using Ardalis.Result;
using Ardalis.SharedKernel;

namespace TryCleanArchitecture.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
