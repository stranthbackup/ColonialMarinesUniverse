using Content.Server.Medical;
using Content.Shared._CMU14.Body.Humanoid.Organ.Stomach;
using Robust.Shared.GameObjects;

namespace Content.Server._CMU14.Body.Humanoid.Organ.Stomach;

public sealed partial class StomachSystem : SharedStomachSystem
{
    [Dependency] private VomitSystem _vomit = default!;

    protected override void ApplyVomit(EntityUid body)
    {
        _vomit.Vomit(body, -20f, -20f);
    }
}
