using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{
    
    private bool inCircle = false;
   
    private GameObject target;
    

    private float triangleNum=0.0f;
    private float squareNum=0.0f;
    private float plusNum=0.0f;
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
            

            //counting captured items
            if (target.tag == "Triangle")
            {
                triangleNum = triangleNum + 1.0f;
                Debug.Log("triangle found");
                GameController.Instance.updateCollection(target);
            }
            else if (target.tag == "Square")
            {
                squareNum = squareNum + 1.0f;
                Debug.Log("Square found");
                GameController.Instance.updateCollection(target);
            }
            else if (target.gameObject.tag == "Plus")
            {
                plusNum = plusNum + 1.0f;
                Debug.Log("Plus found");
                GameController.Instance.updateCollection(target);
            }
            else
            {
                Debug.Log("clear out");
                triangleNum = 0;
                squareNum = 0;
                plusNum = 0;
                GameController.Instance.cleanCollection();
            }

            if (triangleNum >= 2.0f && squareNum >= 1.0f && plusNum >= 1.0f)
            {
                GameController.Instance.UpdateText();
            }
            
           
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        inCircle = true;
        
        
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
