using Robust.Shared.GameObjects;

namespace Content.Shared._CMU14.Body.Humanoid.Bone.Events;

[ByRefEvent]
public readonly record struct FractureSeverityChangedEvent(
    EntityUid Body,
    EntityUid Part,
    FractureSeverity Old,
    FractureSeverity New);
