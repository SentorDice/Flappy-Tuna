using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnBehavior : MonoBehaviour
{
    public GameObject pipePrefab;
    private float timer = 0;
    public int spawnTime = 11;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnTime)
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        Vector3 newY = new Vector3(transform.position.x, Random.Range(-8, 8), transform.position.z);
        Instantiate(pipePrefab, newY, transform.rotation);
    }
}
