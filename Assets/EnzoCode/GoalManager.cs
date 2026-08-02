using UnityEngine;

public class GoalManager : MonoBehaviour
{
    //================================================================================================================================
    //================================================================================================================================
    public void SelectGoalOne() {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameFlowManager>().SetCurrentGoal(GameFlowManager.GameGoal.FirstGoal);
    }

    //================================================================================================================================
    //================================================================================================================================
    public void SelectGoalTwo() {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameFlowManager>().SetCurrentGoal(GameFlowManager.GameGoal.SecondGoal);
    }
}
