using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPop : MonoBehaviour {
    public GameObject blob;
    [Header("bush")]
    public GameObject bush;
    private float transtime = 30;
    private bool triggered = false;
    private float blobtime = 12;
    private bool everythingdone = false;
    private GameObject audi;
    // Use this for initialization
    void Start() {
        audi = GameObject.Find("AudioManager");
        bush.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        if (triggered == true&&transtime>=15)
        {
            transtime -= 1;
            blob.transform.localScale -= new Vector3(0.03f, 0.03f, 0.03f);
            
        }
     
       if(triggered==true && transtime < 15 && transtime>=0 && blobtime>=0)
        {
            blob.transform.localScale = new Vector3(0, 0, 0);
            bush.SetActive(true);
            bush.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            blobtime -= 1;

        }
        if (triggered==true && transtime < 0)
        {
            Destroy(blob);
        }
       if (blobtime < 0 && everythingdone==false)
        {
            bush.transform.localScale = new Vector3(1, 1, 1);
            everythingdone = true;
            audi.SendMessage("pop");
        }   
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Player") {//If player touches butterfly
            if (triggered == false)
            {
                audi.SendMessage("shrink");
                triggered = true;
            }
             
            

        }
    }
}