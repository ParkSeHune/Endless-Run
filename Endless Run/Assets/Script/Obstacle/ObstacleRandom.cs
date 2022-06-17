using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRandom : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject[] prefab;

    //MeshRenderer �ʿ�
    //ȭ�� ������ ������ ���� ������Ʈ ����
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0.1f, 10);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }

    private void Update()
    {
        if (GameManager.instance.condition == false) return;

        transform.Translate(Vector3.back * GameManager.instance.speed * Time.deltaTime);
    }

    private void OnEnable()
    {
        int rand = Random.Range(0, 3);

        for (int i = 0; i < prefab.Length; i++)
        {
            prefab[i].SetActive(false);
        }

        prefab[rand].SetActive(true);
    }
}
