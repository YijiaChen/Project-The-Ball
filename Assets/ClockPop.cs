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

    [Header("bushes")]

    public GameObject bush1;
    public GameObject bush2;
    public GameObject bush3;
    public GameObject bush4;
    public GameObject bush5;
    
  

    private float transtime = 80;
    private bool triggered = false;
    // Use this for initialization
    void Start() {  

    }

    // Update is called once per frame
    void Update() {
        if (triggered == true&&transtime>=0)
        {
            transtime -= 1;
            Blob1.transform.localScale += new Vector3(-0.002f, -0.002f, -0.002f);
            Blob2.transform.localScale += new Vector3(-0.002f, -0.002f, -0.002f);
            Blob3.transform.localScale += new Vector3(-0.002f, -0.002f, -0.002f);
            Blob4.transform.localScale += new Vector3(-0.001f, -0.001f, -0.001f);
            Blob5.transform.localScale += new Vector3(-0.002f, -0.002f, -0.002f);
            Blob6.transform.localScale += new Vector3(-0.002f, -0.002f, -0.002f);
        }
       if(triggered==true && transtime < 0)
        {
            Destroy(Blob1);
            Destroy(Blob2);
            Destroy(Blob3);
            Destroy(Blob4);
            Destroy(Blob5);
            Destroy(Blob6);
            bush1.SetActive(true);
            bush2.SetActive(true);
            bush3.SetActive(true);
            bush4.SetActive(true);
            bush5.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Player") {//If player touches butterfly
            triggered = true;
            Debug.Log("Blob poof!!");
        }
    }
}