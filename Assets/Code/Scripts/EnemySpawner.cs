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

    private void Start()
    {
        enemiesLeftToSpawn = baseEmenies;

    }

    private int enemiesPerWave()
    {
        return Mathf.RoundToInt(baseEmenies * Mathf.Pow(currentWave, difficultyScalingFactor));
    }

}
