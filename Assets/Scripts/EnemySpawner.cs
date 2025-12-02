using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("TARGET")]
    public Transform player;

    [Header("SPAWN AREA")]
    public float spawnWidth = 12f;
    public float spawnHeight = 10f;

    [Header("ALL ENEMIES")]
    public EnemiesDataSO[] enemyTypes;

    private float[] timers;

    private void Awake()
    {
        timers = new float[enemyTypes.Length];
    }

    private void Update()
    {
        for (int i = 0; i < enemyTypes.Length; i++)
        {
            timers[i] += Time.deltaTime;

            if (timers[i] >= enemyTypes[i].SpawnRate)
            {
                timers[i] = 0f;
                SpawnEnemy(enemyTypes[i]);

            }
        }
    }


    void SpawnEnemy(EnemiesDataSO data)
    {
        if (data.prefab == null)
            return;

        Vector2 spawnPos = GetSpawnPosition();

        GameObject enemyObj = Instantiate(data.prefab, spawnPos, Quaternion.identity);

        EnemyBase behaviour = enemyObj.GetComponent<EnemyBase>();

    }
    public void UpdatePlayerReference(Transform newPlayerTransform)
    {
        player = newPlayerTransform;
    }
    public void OnDrawGizmos()
    {
        Color gizmoColor = Color.green;
        Vector3 size = new Vector3( spawnWidth, spawnHeight, 0);
    }
    Vector2 GetSpawnPosition()
    {
        float x, y;
        int side = Random.Range(0, 4); 

        switch (side)
        {
            case 0: // Arriba
                x = Random.Range(-spawnWidth, spawnWidth);
                y = spawnHeight;
                break;

            case 1: // Abajo
                x = Random.Range(-spawnWidth, spawnWidth);
                y = -spawnHeight;
                break;

            case 2: // Izquierda
                x = -spawnWidth;
                y = Random.Range(-spawnHeight, spawnHeight);
                break;

            default: // Derecha
                x = spawnWidth;
                y = Random.Range(-spawnHeight, spawnHeight);
                break;
        }

        return (Vector2)player.position + new Vector2(x, y);
    }
}