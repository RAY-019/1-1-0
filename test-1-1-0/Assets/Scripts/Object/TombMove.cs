using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombMove : MonoBehaviour
{
    private Animator anim;
    private int a = 0;
    public GameObject Fork;
    public bool TombCanMove = false;
    public static bool change_f = false;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TombCanMove = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TombCanMove = false;
        }
    }
    void move()
    {

        if (Input.GetKeyDown(KeyCode.Q) && TombCanMove && N_PlayControl.isMove)
        {
            a ++;

            if (a == 1)
            {
                anim.SetTrigger("move1");
            }

            if (a == 2)
            {
                anim.SetTrigger("move2");
            }

            if (a == 3)
            {
                anim.SetTrigger("move3");
            }

            if(a == 4)
            {
                Destroy(Fork);
                change_f = true;
            }

            if (a > 4)
            {
                a = 4;
            }
        }
    }

}
