using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController1: MonoBehaviour
{
    GameObject audi;
    public float jumpback;
    private bool end = false;
    private void Start()
    {
        audi = GameObject.Find("AudioManager");
    }
    private void Update()
    {
        if (end == true)
        {
            jumpback -= Time.deltaTime;
            if (jumpback < 0)
            {
               SceneManager.LoadScene(2, LoadSceneMode.Single);
               Cursor.visible = true;
            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            if (end == false)
            {
               audi.SendMessage("gateOpen");
               end = true;
            }
           
           
            //Debug.Log("Restarting Game");

        }
    }
}
