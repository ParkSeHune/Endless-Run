using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject popUp;
    public bool condition;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            popUp.SetActive(true);
            condition = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && condition)
        {
            Time.timeScale = 1;
            popUp.SetActive(false);
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
