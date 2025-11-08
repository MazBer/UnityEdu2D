using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int baseEnemiesPerWave = 3;
    public float spawnInterval = 1.5f;
    public float waveCooldown = 3f;
    public float difficultyMultiplier = 1.3f;
    public float spawnIntervalDecrease = 0.1f;
    public float minSpawnInterval = 0.3f;
    public Transform spawnCenter;
    public float spawnRadius = 5f;
    
    private int currentWave = 0;
    private int enemiesInCurrentWave = 0;
    private int enemiesSpawned = 0;
    private bool isSpawning = false;
    private float currentSpawnInterval;
    
    private void Start()
    {
        if (spawnCenter == null)
        {
            spawnCenter = transform;
        }
        
        currentSpawnInterval = spawnInterval;
        
        StartCoroutine(StartNewWave());
    }
    
    private IEnumerator StartNewWave()
    {
        isSpawning = true;
        currentWave++;
        
        // Bu dalgada kaç düşman spawn olacak hesapla
        enemiesInCurrentWave = Mathf.RoundToInt(baseEnemiesPerWave * Mathf.Pow(difficultyMultiplier, currentWave - 1));
        enemiesSpawned = 0;
        
        currentSpawnInterval = Mathf.Max(minSpawnInterval, spawnInterval - (spawnIntervalDecrease * (currentWave - 1)));
        
        Debug.Log($"=== DALGA {currentWave} BAŞLADI ===");
        Debug.Log($"Düşman Sayısı: {enemiesInCurrentWave}");
        Debug.Log($"Spawn Aralığı: {currentSpawnInterval:F2} saniye");
        
        while (enemiesSpawned < enemiesInCurrentWave)
        {
            SpawnEnemy();
            enemiesSpawned++;
            yield return new WaitForSeconds(currentSpawnInterval);
        }
        
        Debug.Log($"Dalga {currentWave} tamamlandı! {waveCooldown} saniye sonra yeni dalga...");
        
        yield return new WaitForSeconds(waveCooldown);
        
        isSpawning = false;
        
        StartCoroutine(StartNewWave());
    }
    
    void SpawnEnemy()
    {
        if (enemyPrefab == null)
        {
            Debug.LogError("Enemy prefabı koy eşşek!");
            return;
        }
        
        Vector3 randomOffset = Random.insideUnitSphere * spawnRadius;
        randomOffset.y = 0; // Yatay düzlemde spawn et
        
        Vector3 spawnPosition = spawnCenter.position + randomOffset;
        
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        
        enemy.name = $"Enemy_Wave{currentWave}_{enemiesSpawned + 1}";
    }
    
    // Spawn bölgesini göster (Scene view'da)
    void OnDrawGizmos()
    {
        if (spawnCenter == null)
            return;
            
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(spawnCenter.position, spawnRadius);
    }
}