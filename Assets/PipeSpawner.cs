using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab; // Reference to the pipe prefab
    public float spawnInterval = 2; // Time interval between spawns
    public float timer = 0; // Timer to track time between spawns
    public float heightOffset = 3.8f; // Maximum height offset for pipe spawning

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe(); // Spawn the first pipe immediately
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime; // Increment the timer by the time elapsed since the last frame
        }
        else
        {
            SpawnPipe(); // Spawn a new pipe
            timer = 0; // Reset the timer
        }
        
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
