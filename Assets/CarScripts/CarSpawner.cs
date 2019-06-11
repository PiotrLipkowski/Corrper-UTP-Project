using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public GameObject car, car2,car3,car4;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    private void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
 
        if(randomIndex == 0)
        {
            Instantiate(car, spawnPoint.position, spawnPoint.rotation);
        }
        if(randomIndex == 1)
        {
            Instantiate(car2, spawnPoint.position, spawnPoint.rotation);
        }
        if (randomIndex == 2)
        {
            Instantiate(car3, spawnPoint.position, spawnPoint.rotation);
        }
        if (randomIndex == 3)
        {
            Instantiate(car4, spawnPoint.position, spawnPoint.rotation);
        }

    }
}
