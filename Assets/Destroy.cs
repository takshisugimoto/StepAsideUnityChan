﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	void OnBecameInvisible() {
		//画面の外に出たオブジェクトを消す
		Destroy (this.gameObject);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
