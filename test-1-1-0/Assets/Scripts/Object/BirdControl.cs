using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BirdControl : MonoBehaviour
{
    public Animator anim;
    public PlayableDirector playableDirector;
    public static bool change;
    public static bool birdclose;

    public GameObject hat;
    void Start()
    {
        hat.gameObject.SetActive(false);
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (H_PlayControl.isplayermove)
        {
            playableDirector.Play();
            Invoke("Play", 1.5f);
        }
    }

    void Play()
    {
        anim.SetTrigger("Fly");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            change = true;
            anim.SetTrigger("GetHat");
            Invoke("CloseBird", 3f);
        }
    }

    void CloseBird()
    {
        hat.gameObject.SetActive(true);
        birdclose = true;
    }
}
