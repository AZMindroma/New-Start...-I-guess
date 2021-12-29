using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public ObjectManager objectManager;
    public Vector3Int playerPosition;

    void Start()
    {
        playerPosition= new Vector3Int((int)transform.position.x,(int)transform.position.z,(int)transform.position.z);
        transform.position=playerPosition;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MovePlayer(new Vector3Int(0, 0, 1));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            MovePlayer(new Vector3Int(-1, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            MovePlayer(new Vector3Int(0, 0, -1));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MovePlayer(new Vector3Int(1, 0, 0));
        }
    }

    void MovePlayer(Vector3Int direction)
    {
        objectManager.CheckPlates();
        objectManager.CubePush(playerPosition, direction);
        transform.position=playerPosition+direction;
        playerPosition=playerPosition+direction;
    }
}