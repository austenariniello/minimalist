using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{
    private float xPosShow = -4.0f;
    private bool inCircle = false;
   
    private GameObject target;
    private float ycontrol=0.0f;

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
            xPosShow += 1.5f;
            
            if(xPosShow<9.0f){
                target.transform.position = new Vector3(xPosShow, 4.0f-ycontrol, 0.0f);
            }
            else if(xPosShow>=9.0f){
                xPosShow=-2.5f;
                ycontrol=ycontrol+1.0f;
                target.transform.position=new Vector3(xPosShow, 4.0f-ycontrol, 0.0f);
            }
            
            target.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            Destroy(target.GetComponent<MoveLeft>());
            Debug.Log(xPosShow);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        inCircle = true;
        if (other.gameObject.tag == "Triangle"){
            triangleNum=triangleNum+1.0f;
            Debug.Log("triangle found");
        }
        else if (other.gameObject.tag == "Square"){
            squareNum=squareNum+1.0f;
            Debug.Log("Square found");
        }
        else if (other.gameObject.tag == "Plus"){
            plusNum=plusNum+1.0f;
            Debug.Log("Plus found");
        }
        
        if(triangleNum>=2.0f && squareNum>=1.0f && plusNum>=1.0f){
           GameController.Instance.UpdateText();
        }
        
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
