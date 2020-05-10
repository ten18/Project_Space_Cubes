using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintTime : MonoBehaviour {

    GameObject script;
    public Text timerText;

	// Use this for initialization
	void Start ()
    {
        // takes time recorded from TimerScript and prints it in 00:00 format
        timerText.text = ("Time: ") + (string.Format("{0:00}:{1:00}", TimerScript.minutes, TimerScript.seconds));
    }

}
