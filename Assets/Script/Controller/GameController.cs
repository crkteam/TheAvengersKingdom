using System.Collections;
using System.Collections.Generic;
using Script.Character;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public MainCharacter mc;

	// Use this for initialization
	void Start () {
		mc = new MainCharacter(Application.absoluteURL);
		mc.draw();
		init test = GameObject.Find("Main_Background_Image").GetComponent<init>();
		test.attack = mc.attribute.attack;
	}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
