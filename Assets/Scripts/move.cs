using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 movement;
    GameObject leftLine;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        movement.x=-speed;
        leftLine=GameObject.Find("leftlinecontrol");
    }

    // Update is called once per frame
    void Update()
    {
        MoveShape();
    }
    void MoveShape(){
        transform.position+=movement*Time.deltaTime;
        if(transform.position.x<=leftLine.transform.position.x){
            Destroy(gameObject);
        }
    }
}
