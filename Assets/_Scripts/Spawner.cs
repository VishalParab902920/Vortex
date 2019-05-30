using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnTime;
    public float spawnDelay;
    private void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
    }

    public void Spawn()
    {
        int spawneeID = Random.Range(0, obstacles.Length);
        GameObject obstacle = obstacles[spawneeID];
        Instantiate(obstacle);
    }
}
