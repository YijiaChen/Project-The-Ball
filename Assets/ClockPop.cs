using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPop : MonoBehaviour {
    public GameObject Blob1;
    public GameObject Blob2;
    public GameObject Blob3;
    public GameObject Blob4;
    public GameObject Blob5;
    public GameObject Blob6;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Player") {     //If player touches butterfly
            Destroy(Blob1);
            Destroy(Blob2);
            Destroy(Blob3);
            Destroy(Blob4);
            Destroy(Blob5);
            Destroy(Blob6);
            Debug.Log("Blob poof!!");
        }
    }
}