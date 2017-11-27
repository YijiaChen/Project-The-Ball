using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPop : MonoBehaviour {
    public GameObject blob;
    [Header("bush")]
    public GameObject bush;
    private float transtime = 80;
    private bool triggered = false;
    private float blobtime = 40;
    private bool everythingdone = false;
    // Use this for initialization
    void Start() {
        bush.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        if (triggered == true&&transtime>=0)
        {
            transtime -= 1;
            blob.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
            
        }
       if(triggered==true && transtime < 0 && blobtime>=0)
        {
            Destroy(blob);
            bush.SetActive(true);
            bush.transform.localScale += new Vector3(0.03f, 0.03f, 0.03f);
            blobtime -= 1;

        }
       if (blobtime < 0 && everythingdone==false)
        {
            bush.transform.localScale = new Vector3(1, 1, 1);
            everythingdone = true;
        }   
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Player") {//If player touches butterfly
            triggered = true;
            Debug.Log("Blob poof!!");
        }
    }
}