﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string suspect;

	public string weapon;

	public string room;



	// Use this for initialization
	void Start () {
		MurderMystery(suspect);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MurderMystery (string person){
		switch(suspect){
			case "Mr. Ketchup": 
			case "Mr. Radish":
				print("I was in the billiard room playing pool");
			break;
			case "Ms. Frysauce":
				print("I was talking on the rotory phone with my mother Mrs. Mayo");
			break;
			case "Mrs. Mayo":
				print ("I was in the kitchen cleaning up the dishes");
			break;
			default:
				print("I am not familiar with "+suspect+"!");
			break;
		}

	}
}
