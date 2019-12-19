using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public GameObject columnPrefab;
    public int columnPoolSize = 5;
    public float spawnRate = 3f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;
    public Vector2 objectStartPos;
    public float spawnXPosition = 5f;
    private float _timeSinceLastSpawned;
    public Queue<GameObject> columnPool = new Queue<GameObject>();
    
    

    void Start()
    {
        _timeSinceLastSpawned = 0f;
        for(int i = 0; i < columnPoolSize; i++)
        {
            AddInstanceToQueue();
        }
    }

    private void AddInstanceToQueue()
    {
        columnPool.Enqueue(Instantiate(columnPrefab, objectStartPos, Quaternion.identity));
    }

    void Update()
    {
        _timeSinceLastSpawned += Time.deltaTime;
        if (GameController.Instance.hasStarted && GameController.Instance.gameOver == false && _timeSinceLastSpawned >= spawnRate) 
        {    
            _timeSinceLastSpawned = 0f;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            if (columnPool.Count <= 0)
            {
                AddInstanceToQueue();
            }
            var columnInstance = columnPool.Dequeue();
            columnInstance.transform.position = new Vector2(spawnXPosition, spawnYPosition);
        }
    }
}
