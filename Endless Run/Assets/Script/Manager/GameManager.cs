using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //GameManager에 인스턴스를 담는 전역변수
    //이 게임 내에서 GameManager instance 이 instance에 담신 오브젝트만 존재할 수 있다
    public static GameManager instance;

    public float speed = 10.0f;
    public int crashCount = 1;
    public bool condition = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
            //Scene이 전환되더라도 파괴되지 않고 유지할 수 있도록 설정
            DontDestroyOnLoad(instance);
        }
        else
        {
            //만약 Scene을 이동했을 떄 그 Scene에도 GameManager가 존재하게 되면 자기자신을 삭제
            Destroy(instance);
        }
    }

    private void Start()
    {
        condition = true;
    }
}
