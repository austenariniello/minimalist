using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{
    private float xPosShow = -4.0f;
    private bool inCircle = false;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if pressed a key and there is a object in the ring, move the object
        // to collection above
        if (Input.anyKeyDown && inCircle)
        {
            xPosShow += 1.5f;
            target.transform.position = new Vector3(xPosShow, 3.0f, 0.0f);
            target.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            Destroy(target.GetComponent<MoveLeft>());
            Debug.Log(xPosShow);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        inCircle = true;
        //if (other.gameObject.tag == "bullet")
        target = other.gameObject;
        Debug.Log("collision occur");
        //Destroy(other.gameObject);
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        inCircle = false;
        Debug.Log("collision over");

    }
}
