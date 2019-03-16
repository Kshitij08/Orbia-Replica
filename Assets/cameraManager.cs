using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{

    private Transform player;

    //public float speedCamera;

    public float camPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if((player.position.y + camPosition) > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y + camPosition, transform.position.z);
        }
    }
}
