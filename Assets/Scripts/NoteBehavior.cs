using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBehavior : MonoBehaviour
{
    
    private bool onTop;
    private bool died = false;
    
    // Start is called before the first frame update
    void Start()
    {
        onTop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Circle")) {
            print("entered circle");
            onTop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("Circle")) {
            print("left circle");
            onTop = false;
        }
    }

    public void ButtonPress(){
        if (onTop) {
            Destroy(gameObject);
        }
    }


}
