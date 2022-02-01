using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private Vector3 startPos = new Vector3(10.0f, 0.0f, 0.0f);
    private bool isMoving = true;
    private Vector3 endPos = new Vector3(-10.0f, 0.0f, 0.0f);
    public float lengthOnScreen = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving) {
            Destroy(gameObject);
        }
    }

    IEnumerator Move() {
        float timeElapsed = 0.0f;
        while (timeElapsed < 1.0f) {
            transform.position = Vector3.Lerp(startPos, endPos, timeElapsed);
            timeElapsed += Time.deltaTime * (1.0f/lengthOnScreen);
            yield return null;
        }
        isMoving = false;
    }


}
