﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour {
    
    public Text scoreText;
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("totalScore").ToString();
	}
}
