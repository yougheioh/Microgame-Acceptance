using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QubusV2 : MonoBehaviour
{
    private Vector2Int gridMoveDirection;
    private Vector2Int gridPosition;
    private float gridMoveTimer;
    private float gridMovetTimerMax;

    private void Awake()
    {
        gridPosition = new Vector2Int(5, 5);
        gridMovetTimerMax = 1f;
        gridMoveTimer = gridMovetTimerMax;
        gridMoveDirection = new Vector2Int(1, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gridMoveDirection.y = 0;
            gridMoveDirection.x = +1;
           
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            gridMoveDirection.y = 0;
            gridMoveDirection.x = 1;
        }

        gridMoveTimer += Time.deltaTime;
        if (gridMoveTimer >= gridMovetTimerMax)
        {
            gridPosition += gridMoveDirection;
            gridMoveTimer -= gridMovetTimerMax;
        }

        transform.position = new Vector3(gridPosition.x, gridPosition.y);
    }
}
