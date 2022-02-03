using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text winText;
    public GameController Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance=this;
    }

    // Update is called once per frame
    public void UpdateText(){
        this.winText.text="You found a present!Win!!";
    }
}
