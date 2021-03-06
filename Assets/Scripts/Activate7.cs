﻿using UnityEngine;
using System.Collections;

public class Activate7 : MonoBehaviour {
	
	public Sprite tada1;
	public Sprite tada2;
	public Sprite tada3;
	public Sprite tada4;
	public Sprite tada5;
	public Sprite tada6;
	public Sprite tada7;
	public SpriteRenderer nyanAnimator1;
	public float framesPerSecond = 5f;
	
	public Sprite tada;
	
	public int Activates = 0;
	public int A = 0;
	public int B = 0;
	public int C = 0;
	public int D = 0;
	public int E = 0;
	public int F = 0;
	public int G = 0;
	
	public bool T1a = false;
	public bool T2a = false;
	public bool T3a = false;
	public bool T4a = false;
	public bool T5a = false;
	public bool T6a = false;
	public bool T7a = false;
	
	private GameObject Pipe1;
	private GameObject Pipe2;
	private GameObject Pipe3;
	private GameObject Pipe4;
	private GameObject Pipe5;
	private GameObject Pipe6;
	private GameObject Pipe7;
	
	public int Ani1 = 0;
	public int Ani2 = 0;
	public int Ani3 = 0;
	public int Ani4 = 0;
	public int Ani5 = 0;
	public int Ani6 = 0;
	public int Ani7 = 0;
	
	private SpriteRenderer sr;
	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}
	
	void changeSprite(){
		
		if(Ani7 == 1){
			sr.sprite = tada7;
		}
	}
	// Update is called once per frame
	void Update () {
		G = PlayerPrefs.GetInt ("G");
		Activates = PlayerPrefs.GetInt ("Activate");
		if (Activates == 0) {
			gameObject.SetActive (false);
		} else if (Activates < 0) {
			gameObject.SetActive (true);
		}
		changeSprite ();
		findTube ();
		tubeAnim ();
		
	}
	
	void findTube(){ 
		
		if (G == 1){
			//PlayerPrefs.SetInt ("C", 0);
			Pipe7 = GameObject.Find ("Pipe7");
			T7a = true;
		}
	}
	
	void tubeAnim(){
		
		if(T7a){
			if(Pipe7 != null){
				Ani7 = 1;
			} 
		}
	}
}
