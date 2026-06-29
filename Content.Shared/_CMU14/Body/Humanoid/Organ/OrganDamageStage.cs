namespace Content.Shared._CMU14.Body.Humanoid.Organ;

public enum OrganDamageStage : byte
{
    Healthy = 0,
    Bruised,
    Damaged,
    Failing,
    Dead,
}

public static class OrganDamageStageExtensions
{
    public static bool IsAtLeast(this OrganDamageStage self, OrganDamageStage other)
        => (byte)self >= (byte)other;
}
