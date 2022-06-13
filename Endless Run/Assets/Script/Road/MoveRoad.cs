using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    Vector3 direction;
    public float speed = 0.0f;
    private void Start()
    {
        direction = Vector3.back; // (0, 0, -1)
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);   
    }
}
