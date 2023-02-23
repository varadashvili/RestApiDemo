using BuberBreakfast.Api.Models;

using ErrorOr;

namespace BuberBreakfast.Api.Services.Breakfasts;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfast);

    ErrorOr<Deleted> DeleteBreakfast(Guid Id);

    ErrorOr<Breakfast> GetBreakfast(Guid Id);

    ErrorOr<UpsertedBreakfastResult> UpsertBreakfast(Breakfast breakfast);
}
