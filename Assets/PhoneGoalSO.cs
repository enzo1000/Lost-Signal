using UnityEngine;

[CreateAssetMenu(fileName = "PhoneGoal", menuName = "Scriptable Objects/PhoneGoal")]
public class PhoneGoalSO : ScriptableObject
{
    public GameFlowManager.GameGoal gameGoal;
    public string GoalOne;
    public string GoalTwo;
}
