using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringManager : MonoBehaviour
{

    public Transform targetRing;

    public bool changeSize = false;

    public float rotationSpeed = 100f;

    public Vector3 oldScale;
    public Vector3 newScale = new Vector3(0, 0, 0);
    public Vector3 scaleFactor = new Vector3(0.05f, 0.05f, 0.1f);

    // Start is called before the first frame update
    void Start()
    {
        oldScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        if (changeSize)
        {
            ChangeSize();
        }        
    }

    void Rotate()
    {
        transform.Rotate(0, 0, 1 * rotationSpeed * Time.deltaTime);
    }

    void ChangeSize()
    {
        
        newScale.x = Mathf.Lerp(oldScale.x, newScale.x, scaleFactor.x);
        newScale.y = Mathf.Lerp(oldScale.y, newScale.y, scaleFactor.y);
        transform.localScale = newScale;
    }

}
