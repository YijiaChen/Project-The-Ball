using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

    public bool isColored;
    public bool changesColor;
    public bool isAWall;
    public float timer;
    private float countdown;

    public Material collidedMaterial;
    public Material oldMaterial;
    private GameObject audi;

    private void Start()
    {
        audi = GameObject.Find("AudioManager");   
    }


    private void Update()
    {
        if (isColored == true)
        {
            countdown -= Time.deltaTime;
            if (countdown < 0)
            {
                isColored = false;
                GetComponent<Renderer>().material = oldMaterial;
                if (isAWall == false)
                {
                  audi.SendMessage("buzzer");
                }
                
            }

        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isColored == false&&isAWall==false)
        {
           audi.SendMessage("activated");
        }
        if (changesColor == true)
        {
            GetComponent<Renderer>().material = collidedMaterial; //When this object collides with another object it changes its material
            isColored = true;
            countdown = timer;
           
        }
    }

}
