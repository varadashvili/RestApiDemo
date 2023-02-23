﻿namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime startDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet);
