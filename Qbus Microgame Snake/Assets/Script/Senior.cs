using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senior : MonoBehaviour
{
    public GameObject senior;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D trigger)

    {
        SpawnSenior();
        Destroy(gameObject);
    }

    void SpawnSenior()
        {
      
        int xPos = Random.Range(-13, 13);
        int yPos = Random.Range(-9, 9);
        GameObject a = Instantiate(senior) as GameObject;
        a.transform.position = new Vector2(xPos, yPos);

    }
}
