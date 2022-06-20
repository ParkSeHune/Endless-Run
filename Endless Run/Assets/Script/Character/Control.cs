using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int count = 0;
    public Animator animator;

    void Update()
    {
        if (GameManager.instance.condition == false) return;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && count > -2)
        {
            SoundManager.instance.SoundCall("Move");
            count--;
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && count < 2)
        {
            SoundManager.instance.SoundCall("Move");
            count++;
            transform.position += Vector3.right;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tire Stack")
        {
            DataManager.instance.Save();
            SoundManager.instance.SoundCall("Collision");
            GameManager.instance.condition = false;
            animator.SetTrigger("Death");
            UIManager.instance.UIActive();
        }
    }
}
