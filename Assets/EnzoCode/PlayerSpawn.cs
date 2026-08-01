using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject player;

    void Start() {
        GameObject spawnedPlayer = Instantiate(player);
        spawnedPlayer.transform.localPosition = transform.localPosition;
    }
}
