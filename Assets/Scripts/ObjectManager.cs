using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] cubes;
    public GameObject[] plates;
    public GameObject[] obstacles;

    public void CubePush(Vector3Int position, Vector3Int direction)
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            if (position + direction == cubes[i].transform.position)
            {
                CubePush(position + direction, direction);
                cubes[i].transform.position += direction;
            }
        }
    }

    public void CheckPlates()
    {
        
        if (cubes.Length == plates.Length)
        {
            int num = 0;
            for (int i = 0; i < cubes.Length; i++)
            {
                if (cubes[i].transform.position.x == plates[i].transform.position.x && cubes[i].transform.position.z == plates[i].transform.position.z)
                {
                    num++;
                }
            }
            
            if (num == cubes.Length)
            {
                print("Success");
            }
        }
        else
        {
            print("Error. Plates and Cubes don't have the same value");
        }         
    }

    public void CheckObstacles()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if (transform.position.x == obstacles[i].transform.position.x && transform.position.z == obstacles[i].transform.position.z)
            {
                transform.position = new Vector3(0,0,0);
            }
        }
    }

}

