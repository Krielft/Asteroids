using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Asteroid asteroidPrefab;
    public GameManager gameManager;
    public int scoreThreshold = 500;
    public float spawnDistance = 12f;
    public float spawnRate = 1f;
    public int amountPerSpawn = 1;
    [Range(0f, 45f)]
    public float trajectoryVariance = 15f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    public void Spawn()
    {
        if (gameManager.score >= scoreThreshold)
        {
            CancelInvoke();
            spawnRate = 0.75f;
            InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
            scoreThreshold = 1500;
            if (gameManager.score >= scoreThreshold)
            {
                CancelInvoke();
                spawnRate = 0.5f;
                InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
                scoreThreshold = 3000;
                if (gameManager.score >= scoreThreshold)
                {
                    CancelInvoke();
                    spawnRate = 0.25f;
                    InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
                    scoreThreshold = 6000;
                    if (gameManager.score >= scoreThreshold)
                    {
                        CancelInvoke();
                        spawnRate = 0.1f;
                        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
                        scoreThreshold = 10000;
                    }
                }
            }
        }
        for (int i = 0; i < amountPerSpawn; i++)
        {
           
            Vector2 spawnDirection = Random.insideUnitCircle.normalized;
            Vector3 spawnPoint = spawnDirection * spawnDistance;

            
            spawnPoint += transform.position;

            
            float variance = Random.Range(-trajectoryVariance, trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

        
            Asteroid asteroid = Instantiate(asteroidPrefab, spawnPoint, rotation);
            asteroid.size = Random.Range(asteroid.minSize, asteroid.maxSize);

            
            Vector2 trajectory = rotation * -spawnDirection;
            asteroid.SetTrajectory(trajectory);
        }
    }
}
