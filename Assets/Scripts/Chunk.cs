using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] float[] lanes = { -3, 0, 3 };
    [SerializeField] GameObject fence;
    [SerializeField] GameObject coin;

    List<int> availableLanes = new List<int> { 0, 1, 2 };
    private void Start()
    {
        SpawnFence();
        SpawnCoin();
            
    }

    private void SpawnFence()
    {
       /* Vector3 pos = new Vector3(lanes[Random.Range(0, lanes.Length)], transform.position.y, transform.position.z);
        Instantiate(fence, pos, Quaternion.identity, this.transform);
       */

       
        int fencesToSpawn = Random.Range(0, lanes.Length);


        for(int i = 0; i < fencesToSpawn; i++)
        {
            if(availableLanes.Count <= 0) break;

            int randomLaneIndex = Random.Range(0, availableLanes.Count);
            int selectedLanes = availableLanes[randomLaneIndex];
            availableLanes.RemoveAt(randomLaneIndex);


            Vector3 spawnPosition = new Vector3(lanes[selectedLanes], transform.position.y, transform.position.z);
            Instantiate(fence, spawnPosition, Quaternion.identity, transform);
        }
    }

    private void SpawnCoin()
    {
        int availableLane = availableLanes[0];
        Vector3 spawnPosition = new Vector3(lanes[availableLane], transform.position.y + 0.7f,  transform.position.z);
        Instantiate(coin, spawnPosition, Quaternion.identity, transform);
    }
        
}
