using Ardalis.Result;
using Ardalis.SharedKernel;

namespace TryCleanArchitecture.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
