﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMouseVisible : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
}
