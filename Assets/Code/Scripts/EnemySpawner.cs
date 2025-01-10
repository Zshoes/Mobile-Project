using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Attributes")]
    [SerializeField] private int baseEmenies = 8;
    [SerializeField] private float enemiesPerSecond = 0.5f;
    [SerializeField] private float timeBetweenWaves = 5f;
    [SerializeField] private float difficultyScalingFactor = 0.75f;

    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;
    private bool isSpawning = false;

    private void Start()
    {
        StartWave(); //Put into a play menu in the future
    }

    private void Update()
    {
        if (!isSpawning) return;

        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= 1f / enemiesPerSecond)
        {
            Debug.Log("Spawning Enemy");
            timeSinceLastSpawn = 0f;   
        }
    }
    private void StartWave()
    {
        isSpawning = true;
        enemiesLeftToSpawn = EnemiesPerWave();
       
    }

    private int EnemiesPerWave()
    {
        return Mathf.RoundToInt(baseEmenies * Mathf.Pow(currentWave, difficultyScalingFactor));
    }

}
