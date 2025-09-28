using System;

public static class GameEvents
{
    public static event Action OnPlayerJumped;
    public static event Action OnSpeedIncreased;
    public static event Action OnScoreMilestoneReached;

    public static void RaisePlayerJumped() => OnPlayerJumped?.Invoke();
    public static void RaiseSpeedIncreased() => OnSpeedIncreased?.Invoke();
    public static void RaiseScoreMilestoneReached() => OnScoreMilestoneReached?.Invoke();
}
