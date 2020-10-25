using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMusic : MonoBehaviour
{
    public AudioSource Startmusic;


    public float timerr;
    public bool startTimer;

    // Start is called before the first frame update
    void Start()
    {
        startTimer = false;
        timerr = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
        timerr -= Time.deltaTime;

        }

        if (timerr <= 0f)
        {
            Debug.Log("Move to next scene");
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Startmusic.Play();
        startTimer = true;
        
    }
}
