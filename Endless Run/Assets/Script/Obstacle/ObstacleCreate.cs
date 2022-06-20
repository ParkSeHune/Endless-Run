using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    public GameObject obstacle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Character")
        {
            SoundManager.instance.SoundCall("LevelDesign");

            if (GameManager.instance.crashCount % 10 == 0)
            {
                DataManager.instance.level++;
            }

            GameManager.instance.speed++;
            GameManager.instance.crashCount++;

            ObjectPooling.objectPool.GetQueue();
        }
    }
}
