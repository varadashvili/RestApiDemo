using BuberBreakfast.Api.Models;
using BuberBreakfast.Api.ServiceErrors;

using ErrorOr;

namespace BuberBreakfast.Api.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();

    public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);

        return Result.Created;
    }

    public ErrorOr<Deleted> DeleteBreakfast(Guid Id)
    {
        _breakfasts.Remove(Id);

        return Result.Deleted;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid Id)
    {
        if (_breakfasts.TryGetValue(Id, out var breakfast))
        {
            return breakfast;
        }

        return Errors.Breakfast.NotFound;
    }

    public ErrorOr<UpsertedBreakfastResult> UpsertBreakfast(Breakfast breakfast)
    {
        var isNewlyCreated = !_breakfasts.ContainsKey(breakfast.Id);

        _breakfasts[breakfast.Id] = breakfast;

        return new UpsertedBreakfastResult(isNewlyCreated);
    }
}
