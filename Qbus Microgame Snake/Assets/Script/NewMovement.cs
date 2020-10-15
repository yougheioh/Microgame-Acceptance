using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float timerMax = 1f;
    private float theTimer;

    public GameObject qubus;


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
           
            transform.position += transform.up;
            theTimer = 0f;
        }
    }
}
