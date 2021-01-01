using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playchange : MonoBehaviour
{
    public GameObject h_player, n_player, nf_player, f_player,bird,birdidle,n_cm;

    void Start()
    {
        h_player.gameObject.SetActive(true);
        n_player.gameObject.SetActive(false);
        nf_player.gameObject.SetActive(false);
        f_player.gameObject.SetActive(false);
    }

    void Update()
    {
        if (BirdControl.change)
        {
            h_player.gameObject.SetActive(false);
            n_player.gameObject.SetActive(true);
        } 
        
        if(BirdControl.birdclose)
        {
            Invoke("TimeLineClose", 0.2f);
        }

        if (TombMove.change_f)
        {
            n_player.gameObject.SetActive(false);
            nf_player.gameObject.SetActive(true);
        }
    }
    void TimeLineClose()
    {
        bird.gameObject.SetActive(false);
        birdidle.gameObject.SetActive(true);
        Invoke("cmclose", 1f);
    }
    void cmclose()
    {
        N_PlayControl.isMove = true;
        n_cm.SetActive(false);
    }
}
