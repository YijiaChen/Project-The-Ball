using System.Collections;
using System.Collections.Generic;
//using System;
using UnityEngine;

public class Clock : MonoBehaviour {

    //float degreePerHour = 30f;
    //float degreePerMinute = 6f;
    float degreePerSecond = 0f;
    float speed = 0;

    public Transform secondsTransform;

    private void Start() {
        speed = Random.Range(0.1f, 6.0f);
    }
    //public bool continuous;

    void Update() {
        degreePerSecond += speed;
        secondsTransform.localRotation = Quaternion.Euler(0f, degreePerSecond, 0f);
    }
}
        /*if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    void UpdateDiscrete ()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, DateTime.Now.Hour * degreePerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler(0f, DateTime.Now.Minute * degreePerMinute, 0f);
        secondsTransform.localRotation =
            Quaternion.Euler(0f, DateTime.Now.Second * degreePerSecond, 0f);
    }

    void UpdateContinuous ()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float) time.TotalHours * degreePerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler(0f, (float) time.TotalMinutes * degreePerMinute, 0f);
        secondsTransform.localRotation =
            Quaternion.Euler(0f, (float) time.TotalSeconds * degreePerSecond, 0f);
    }
    
}*/
