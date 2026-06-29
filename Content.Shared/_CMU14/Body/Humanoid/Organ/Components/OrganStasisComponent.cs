using Robust.Shared.GameStates;
using Content.Shared._CMU14.Body.Humanoid.Organ.Systems;

namespace Content.Shared._CMU14.Body.Humanoid.Organ.Components;

/// <summary>
///     Marker for detached organs. Freezes <see cref="OrganHealthComponent"/>
///     regen; once <see cref="ExpireAt"/> is reached the organ is marked Dead.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, AutoGenerateComponentPause]
[Access(typeof(SharedOrganHealthSystem))]
public sealed partial class OrganStasisComponent : Component
{
    [DataField, AutoNetworkedField, AutoPausedField]
    public TimeSpan ExpireAt;
}
