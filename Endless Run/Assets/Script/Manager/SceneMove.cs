using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void SceneNumber(string name)
    {
        SoundManager.instance.SoundCall("Click");
        SceneManager.LoadScene(name);
        GameManager.instance.condition = true;
        GameManager.instance.speed = 10;
    }
}
