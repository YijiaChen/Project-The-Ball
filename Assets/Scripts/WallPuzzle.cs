using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPuzzle : MonoBehaviour {

    public List<ColorChanger> triggers;
    public List<GameObject> wallsToTurnOff;
    private GameObject aud;
    private bool sendonce = false;

	// Use this for initialization
	void Start () {
        aud= GameObject.Find("AudioManager");
	}
	
	// Update is called once per frame
	void Update () {


        int numColored = 0;
        foreach (ColorChanger thisColorChanger in triggers)
        {
            if (thisColorChanger.isColored == true)
            {
                numColored++; 
            }
        }

        if (numColored == triggers.Count)
        {
            
            // turn off the wall
            foreach (GameObject thisObject in wallsToTurnOff)
            {
                thisObject.SetActive(false);
                if (sendonce == false)
                {
                    aud.SendMessage("gateOpen");
                    sendonce = true;
                }
                

            }
           
        }

	}
}
