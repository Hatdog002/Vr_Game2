using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawnner : MonoBehaviour
{
    public static Spawnner instance = null;

    public GameObject[] objectsToSpawn;  // The prefab of the object to spawn
    public Transform[] spawnPoints;   // Array of spawn point


    public GameObject magzTospawn;
    public Transform[] MagzSpawn;

    public float spawnInterval = 2f;  // Interval between spawns
    public int maxSpawnCount = 10;
    public int maxSpawnCountMags = 1;

    public int spawnCount;
    public int spawnCountMags;
    public int SpawnKill;
    private float timer;              // Timer to track spawn time

    public GameManager Manager;

    public TextMeshProUGUI wave;
    public float killcounter;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        timer = spawnInterval;
        spawnCount = 0;
        
    }

    private void Update()
    {
        if (Manager.StartGame == true)
        {
           
            if (spawnCountMags >= maxSpawnCountMags)
            {
                // Stop spawning
                return;
            }
            int randomSpawnIndexMags = Random.Range(0, MagzSpawn.Length);
            if (killcounter == 10)
            {
                GameObject MagToSpawn = magzTospawn;
                Transform MagpawnPoint = MagzSpawn[randomSpawnIndexMags];

                Instantiate(MagToSpawn, MagpawnPoint.position, MagpawnPoint.rotation);

                killcounter = 0;
            }

            if (spawnCount >= maxSpawnCount)
            {
                // Stop spawning
                return;
            }

            // Decrease timer
            timer -= Time.deltaTime;

            // Check if it's time to spawn a new object
            if (timer <= 0f)
            {
                // Randomly select a prefab and spawn point index
                int randomObjectIndex = Random.Range(0, objectsToSpawn.Length);
                int randomSpawnIndex = Random.Range(0, spawnPoints.Length);

                if (Manager.WaveAt == 1)
                {
                    maxSpawnCount = 5;
                    
                    GameObject objectToSpawn = objectsToSpawn[0];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;

                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 2)
                {
                    maxSpawnCount = 10;
                   
                    GameObject objectToSpawn = objectsToSpawn[0];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;

                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 3)
                {
                    maxSpawnCount = 10;
                    

                    int randomObjectIndex3 = Random.Range(0, 2);

                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex3];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;

                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 4)
                {
                    maxSpawnCount = 15;
                    

                    int randomObjectIndex3 = Random.Range(0, 2);

                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex3];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;
                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 5)
                {
                    maxSpawnCount = 20;
                    

                    int randomObjectIndex3 = Random.Range(0, 2);

                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex3];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;
                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 6)
                {
                    maxSpawnCount = 25;
                    

                    int randomObjectIndex3 = Random.Range(0, 2);

                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex3];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;
                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 7)
                {
                    maxSpawnCount = 25;
                  

                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;
                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 8)
                {
                    maxSpawnCount = 30;
                    

                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;
                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 9)
                {
                    maxSpawnCount = 35;
                   
                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;
                    wave.text = "Wave " + Manager.WaveAt;
                }
                if (Manager.WaveAt == 10)
                {
                    maxSpawnCount = 40;
                 
                    GameObject objectToSpawn = objectsToSpawn[randomObjectIndex];
                    Transform spawnPoint = spawnPoints[randomSpawnIndex];

                    // Instantiate the selected object at the chosen spawn point
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

                    // Increment spawn count
                    spawnCount++;

                    // Reset timer
                    timer = spawnInterval;
                    wave.text = "Wave " + Manager.WaveAt;
                }
            }
        }
        
    }

   
}

