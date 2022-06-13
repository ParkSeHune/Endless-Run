using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    //생성할 게임 오브젝트
    public GameObject road;

    public float speed = 1.0f;

    List<GameObject> roadList;

    //위치값 설정
    Vector3 nextRoad = Vector3.zero;

    int firstRoad = 0, lastRoad = 0;

    void Start()
    {
        roadList = new List<GameObject>();

        for (int i = 0; i < 3; i++)
        {
            roadList.Add(Instantiate(road, nextRoad, Quaternion.identity));
            nextRoad += Vector3.forward * 36f;
        }
    }

    void Update()
    {
        RoadMove();
    }

    void RoadMove()
    {
        for (int i = 0; i < roadList.Count; i++)
        {
            roadList[i].transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if (roadList[lastRoad].transform.position.z <= -36)
        {
            firstRoad = lastRoad - 1;

            if (firstRoad < 0)
            {
                firstRoad = roadList.Count - 1;
            }

            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 36;

            lastRoad++;

            if (lastRoad >= roadList.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
