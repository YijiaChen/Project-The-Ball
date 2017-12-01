using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour {
    public AudioSource audi;
    public AudioClip counting;
    public AudioClip buzz;
    public AudioClip wallGone;
    public AudioClip click;
    public AudioClip popsound;
    public AudioClip shrinkSound;


	// Use this for initialization
	void Start () {
        audi = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
    void buzzer()
    {
        audi.PlayOneShot(buzz);
    }
    void activated()
    {
       // audi.PlayOneShot(counting);
        audi.PlayOneShot(click);
    }
    void gateOpen()
    {
        audi.PlayOneShot(wallGone);
    }
    void shrink()
    {
        audi.PlayOneShot(shrinkSound);
    }
    void pop()
    {
        audi.PlayOneShot(popsound);
 
    }
}
