using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject snakePrefab;
    public Snake Head;
    public Snake Tail;
    public int NESW;
    public Vector2 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimerInvoke", 0, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TimerInvoke ()
        {
        Movement();
    }

    void Movement()
    {
        GameObject temp;
        nextPos = Head.transform.position;
        switch(NESW)
        {
            case 0:
                nextPos = new Vector2(nextPos.x, nextPos.y + 1);
                break;
            case 1:
                nextPos = new Vector2(nextPos.x + 1, nextPos.y);
                break;
            case 2:
                nextPos = new Vector2(nextPos.x, nextPos.y - 1);
                break;
            case 3:
                nextPos = new Vector2(nextPos.x - 1, nextPos.y);
                break;
        }
        temp = (GameObject)Instantiate(snakePrefab, nextPos, transform.rotation);
        Head.Setnext(temp.GetComponent<Snake>());
        Head = temp.GetComponent<Snake>();

        return;
    }
}
