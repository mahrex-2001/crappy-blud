using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 2f;

    // public float minYPosition = -3.5f;
    // public float maxYPosition = 4f;

    private float height = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnPrefab", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // making new pipes everytime! 
    void spawnPrefab()
    {
        float minHeight = transform.position.y - height;
        float maxHeight = transform.position.y + height;

        float randY = Random.Range(minHeight, maxHeight);

        Vector3 spawnPosition = new Vector3(transform.position.x, randY, transform.position.z);

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
