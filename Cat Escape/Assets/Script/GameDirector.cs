﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject HP;
	// Use this for initialization
	void Start () {
        this.HP = GameObject.Find("HP");
	}
	
	// Update is called once per frame
	public void DecreaseHP () {
        this.HP.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
