using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAnimation : MonoBehaviour {

    public string movementAnimation;
    Animator anim;


	void Start () {
        anim = GetComponent<Animator>();
        float randomStart = Random.Range(0f, anim.GetCurrentAnimatorStateInfo(0).length);
        anim.Play(movementAnimation, 0, randomStart);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
