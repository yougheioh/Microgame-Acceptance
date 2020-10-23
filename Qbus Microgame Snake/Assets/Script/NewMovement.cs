using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewMovement : MonoBehaviour
{
   

    public GameObject qubus;
    public GameObject tail;
    private Vector2 direction;
    public float speed = 1f;
    public float moveRate = 0.3f;

    public List<Transform> tailPositions;
    public List<Transform> tailRotate;
    public int seniorCount;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.up;
        InvokeRepeating("Move", moveRate, moveRate);

        seniorCount = 0;
  
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDirection();
        
    }

    void Move()
        {
            Vector3 lastPos = transform.position;
        
        transform.Translate(direction * speed);
        

            if (tailPositions.Count >= 1)
            {
                tailPositions.Last().position = lastPos;
                tailPositions.Insert(0, tailPositions.Last());
                tailPositions.RemoveAt(tailPositions.Count - 1);
                return;
            }

        }
    
    void ChangeDirection()
    {
            if (Input.GetMouseButtonDown(0))

            {
                qubus.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
            }

            if (Input.GetMouseButtonDown(1))
            {
                qubus.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
            }
           
        }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        Vector2 spawnPos = new Vector2(10,10); 
        if (trigger.tag == "Senior")
        {
            seniorCount += 1;
            GameObject newTail = Instantiate(tail, spawnPos, Quaternion.identity);
            newTail.transform.parent = GameObject.Find("Tail Holder").transform;
            tailPositions.Add(newTail.transform);
            Debug.Log("Collided with Senior");

        }
    }
}
