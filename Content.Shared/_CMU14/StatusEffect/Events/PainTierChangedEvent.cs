using Content.Shared._CMU14.StatusEffect;
using Robust.Shared.GameObjects;

namespace Content.Shared._CMU14.StatusEffect.Events;

[ByRefEvent]
public readonly record struct PainTierChangedEvent(
    EntityUid Body,
    PainTier OldTier,
    PainTier NewTier);
