using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] g_spawner;
    [HideInInspector] public float adjustDelay;
    private bool isDelaySpawn;
    private bool stopSpawning;
    private void FixedUpdate()
    {
        SpawnRandomly();
    }

    private IEnumerator DelaySpawner()
    {
        isDelaySpawn = true;
        yield return new WaitForSeconds(adjustDelay);
        isDelaySpawn = false;
    }
    public void StartSpawn()
    {
        stopSpawning = false;
    }
    public void StopSpawn()
    {
        stopSpawning = true;
    }
    private void SpawnRandomly()
    {
        if (!isDelaySpawn && !stopSpawning)
        {
            int getRandomValue = Random.Range(0, g_spawner.Length);
            Vector3 spawnPosition = g_spawner[getRandomValue].transform.GetChild(0).transform.position - 5f * Vector3.up;
            Instantiate(GameManager.instance.g_assignEnemy, spawnPosition, Quaternion.identity);
            StartCoroutine(DelaySpawner());
        }
    }
}
