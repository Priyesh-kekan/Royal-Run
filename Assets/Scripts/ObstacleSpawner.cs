using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;


public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] int numToSpawn = 10;
    [SerializeField] int waitPerSpawn = 1;
    [SerializeField] float spawnWidth = 3f;
    [SerializeField] GameObject obstacleParent;


    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(waitPerSpawn);
            GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnWidth, +spawnWidth), transform.position.y, transform.position.z);    
            Instantiate(obstacle, spawnPosition, Random.rotation, obstacleParent.transform);
            numToSpawn--;
        }
    }
}
