namespace Content.Shared._CMU14.Body.Humanoid.Organ.Eyes;

/// <summary>
///     Pushes the EyeDamage → blur curve out so blur only kicks in once
///     accumulated damage exceeds <see cref="Threshold"/>. Subtracted from
///     the body's effective blur on every <c>GetBlurEvent</c>.
/// </summary>
[RegisterComponent]
public sealed partial class CMUBlurDelayComponent : Component
{
    [DataField]
    public float Threshold = 12f;
}
