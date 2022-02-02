using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public List<GameObject> shapes=new List<GameObject>();
    public float spawnTime;
    private float countTime;
    private Vector3 spawnPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnShape();
    }
    public void SpawnShape(){
        countTime=Time.deltaTime;
        spawnPosition=transform.position;
        spawnPosition.y=-0.13f;
        

        if(countTime>=spawnTime){
            createShape();
            countTime=0;
        }
    }
    public void createShape(){
        int index=Random.Range(0,shapes.Count);
        Instantiate(shapes[index],spawnPosition,Quaternion.identity, this.transform);
    }
}
