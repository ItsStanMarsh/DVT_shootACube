using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	public GameObject cubePrefab;
    public float spawnThreshold = 1f;
    private float spawnTimer = 0f;
    private float tempA = 0;
    public float rangeX = 10;


    void Update ()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
        }
	}

    private void SpawnCube()
    {
        Vector3 spawnPosition = new Vector3(rdm(), 15, 0);
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

        spawnTimer = 0;

    }
    private float rdm()
    {
        tempA = Random.value;
        tempA *= rangeX;
        tempA -= (rangeX / 2);
        return tempA;
    }

    
}
