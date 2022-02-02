using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public List<GameObject> shapes = new List<GameObject>();
    public float spawnTimeLow;
    public float spawnTimeHigh;
    private float spawnTime;
    private float countTime;
    private Vector3 spawnPosition = new Vector3(10.0f, 0.0f, 0.0f);

    void Start()
    {
        spawnTime = Random.Range(spawnTimeLow, spawnTimeHigh);
        StartCoroutine(SpawnNote());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void createShape(){
        int index = Random.Range(0,shapes.Count);
        Instantiate(shapes[index], spawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnNote() {
        while(true) {
            countTime += Time.deltaTime;

            if(countTime >= spawnTime) {
                createShape();
                countTime -= spawnTime;
                spawnTime = Random.Range(spawnTimeLow, spawnTimeHigh);
            }

            yield return null;
        }
    }
}
