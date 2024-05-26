using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrow : MonoBehaviour
{
    public GameObject objectsToSpawnStone;
    public Transform SpawnStone;

    public int maxSpawnCount = 1;

    public int spawnCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCount >= maxSpawnCount)
        {
            // Stop spawning
            return;
        }

        if (SpawnStone != null)
        {
            GameObject objectToSpawn = objectsToSpawnStone;
            Transform spawnPoint = SpawnStone;

            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

            spawnCount++;
            Invoke("ZeroCounter", 1f);
        }
    }

    public void ZeroCounter()
    {
        spawnCount = 0;
    }
}
