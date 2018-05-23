using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript2 : MonoBehaviour {

    public GameObject cubePrefab;
    public float spawnThreshold = 1f;
    


    private float spawnTimer = 0;
    


    private void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();


        }
       

    }


    private void SpawnCube()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-7.0f, 7.0f), 200, -0);
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        spawnTimer = -3;


    }

}
