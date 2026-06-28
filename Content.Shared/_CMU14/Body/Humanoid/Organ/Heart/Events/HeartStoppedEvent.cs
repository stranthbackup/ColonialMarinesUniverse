using Robust.Shared.GameObjects;

namespace Content.Shared._CMU14.Body.Humanoid.Organ.Heart.Events;

[ByRefEvent]
public readonly record struct HeartStoppedEvent(EntityUid Body, EntityUid Heart);
