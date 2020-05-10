using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TutorialPrompt : MonoBehaviour {

	void Update ()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            gameObject.SetActive(false);
        }

    }
}
