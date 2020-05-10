using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour {

    float startTime;
    public static float time;
    public static float minutes;
    public static float seconds;

	void Start () {
        startTime = 0;
	}
	
	void Update () {
        time = Time.time - startTime;
        minutes = (time / 60);
        float seconds = (time % 60);
	}
}
