using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoad : MonoBehaviour
{
    public GameObject Road;



    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Road, new Vector3(0, 0, i * 6), Quaternion.identity);
        }
    }
}
