using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject player;

    void Awake() {
        GameObject spawnedPlayer = Instantiate(player);
        spawnedPlayer.transform.localPosition = transform.localPosition;
    }
}
