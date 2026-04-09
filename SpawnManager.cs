using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Array to hold different animal prefabs to spawn
    private float spawnRangeX = 20.0f; // Range on the X-axis where animals can spawn
    private float spawnPosZ = 20.0f; // Fixed Z position where animals will spawn

    private float startDelay = 1.0f; // Delay before the first animal spawns
    private float spawnInterval = 1.5f; // Time interval between spawns of animals
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // Repeatedly call the SpawnRandomAnimal method after a delay and at regular intervals
    }
    void SpawnRandomAnimal() // Method to spawn a random animal from the array of prefabs
    {
        //below i generate a random index to select a random animal prefab from the array and then spawn it at a random position within the defined range on the X-axis and a fixed Z position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.S))
        //SpawnRandomAnimal();

    }
}
