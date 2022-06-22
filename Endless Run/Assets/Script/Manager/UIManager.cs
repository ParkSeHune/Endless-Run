using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject popUp;
    public bool condition = false;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && condition == false)
        {
            Time.timeScale = 0;
            popUp.SetActive(true);
            condition = true;
            GameManager.instance.condition = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && condition == true)
        {
            Time.timeScale = 1;
            popUp.SetActive(false);
            condition = false;
            GameManager.instance.condition = true;
        }
    }

    public void UIActive()
    {
        Invoke("InvokeActive", 1.5f);
    }

    public void InvokeActive()
    {
        popUp.SetActive(true);
    }
}
