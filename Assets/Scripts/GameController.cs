using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private float xPosShow = -4.0f;
    private float ycontrol = 0.0f;

    public List<GameObject> collection = new List<GameObject>();
    public Text winText;
    public static GameController Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance=this;
    }

    // Update is called once per frame
    private void Update()
    {
        foreach (GameObject item in collection)
        {
            Debug.Log("collection: " + item.tag);
        }
        
    }
    public void UpdateText(){
        this.winText.text="You found a present!Win!!";
    }

    public void updateCollection(GameObject target)
    {
        xPosShow += 1.5f;

        if (xPosShow < 9.0f)
        {
            target.transform.position = new Vector3(xPosShow, 4.0f - ycontrol, 0.0f);
        }
        else if (xPosShow >= 9.0f)
        {
            xPosShow = -2.5f;
            ycontrol = ycontrol + 1.0f;
            target.transform.position = new Vector3(xPosShow, 4.0f - ycontrol, 0.0f);
        }
        target.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        Destroy(target.GetComponent<MoveLeft>());
        collection.Add(target);
    }

    public void cleanCollection()
    {
        foreach (GameObject item in collection)
        {
            Destroy(item);
        }
        collection.Clear();
        xPosShow = -4.0f;
        ycontrol = 0.0f;
        this.winText.text = "";
    }


}
