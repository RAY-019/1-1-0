using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class H_PlayControl : MonoBehaviour
{
    private Animator anim;
    public static bool isplayermove;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        isplayermove = false;
    }
    void Update()
    {
        StartGame();
    }

    void StartGame()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Invoke("goanim", 1f);
            anim.SetTrigger("Idle");
            isplayermove = true;
        }
    }

   //void goanim()
    //{
        //isplayermove = true;
    //}
}