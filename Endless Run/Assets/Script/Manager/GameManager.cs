using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //GameManager�� �ν��Ͻ��� ��� ��������
    //�� ���� ������ GameManager instance �� instance�� ��� ������Ʈ�� ������ �� �ִ�
    public static GameManager instance;

    public bool condition = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
            //Scene�� ��ȯ�Ǵ��� �ı����� �ʰ� ������ �� �ֵ��� ����
            DontDestroyOnLoad(instance);
        }
        else
        {
            //���� Scene�� �̵����� �� �� Scene���� GameManager�� �����ϰ� �Ǹ� �ڱ��ڽ��� ����
            Destroy(instance);
        }
    }
}