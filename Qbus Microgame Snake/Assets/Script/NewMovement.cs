using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewMovement : MonoBehaviour
{
    public float timerMax = 1f;
    private float theTimer;

    public GameObject qubus;
    public GameObject tail;

    public List<Transform> tailPositions;

    // Start is called before the first frame update
    void Start()
    {
        theTimer = 0;
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {
            qubus.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }

        if (Input.GetMouseButtonDown(1))
        {
            qubus.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }
        theTimer += Time.deltaTime;
        if(theTimer >= timerMax)
        {
            //Moveit();
            transform.position += transform.up * 1;
            theTimer = 0f;
        }

        void Moveit()
        {
            Vector3 lastPos = transform.position;


            tailPositions.Last().position = lastPos;
            return;
        }


    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        Vector2 spawnPos = new Vector2(5, 5); 
        if (trigger.tag == "Senior")
        {
            GameObject newTail = Instantiate(tail, spawnPos, Quaternion.identity);
            newTail.transform.parent = GameObject.Find("Tail Holder").transform;
            tailPositions.Add(newTail.transform);
            Debug.Log("Collided with Senior");

        }
    }
}
