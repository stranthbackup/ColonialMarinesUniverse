using Robust.Shared.GameStates;

namespace Content.Shared._CMU14.Body.Humanoid.Organ.Eyes;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedEyesSystem))]
public sealed partial class EyesComponent : Component
{
    [DataField]
    public bool IsLeftEye = true;
}
