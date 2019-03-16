using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;

    public Transform target;

    public Transform lastRing;

    bool move = false;

    public sceneManager sm;

    public GameObject endScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
        }

        if(move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if(transform.position == target.position)
        {
            move = false;
            target = target.GetComponent<ringManager>().targetRing.GetComponent<Transform>();
        }

        if(transform.position == lastRing.position)
        {
            endScreen.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            transform.SetParent(col.transform);
            gameObject.GetComponent<playerController>().enabled = false;
            Camera.main.GetComponent<cameraManager>().enabled = false;
            col.gameObject.GetComponentInParent<ringManager>().rotationSpeed = 0f;


            sm.Restart();
            //Debug.Log("ASDDSD");
        }
    }

}
