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
        Debug.Log("Spawned a Senior :3");
        int xPos = Random.Range(-7, 7);
        int yPos = Random.Range(-4, 4);
        GameObject a = Instantiate(senior) as GameObject;
        a.transform.position = new Vector2(xPos, yPos);

    }
}
