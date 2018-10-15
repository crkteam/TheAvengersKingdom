using System;
using Assets.Scripts.Json;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using System.IO;
using Attribute = Script.Character.Attribute;

public class Test : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		test();
	}

	public void test()
	{
		SearchTable s = new SearchTable();
		Attribute a = new Attribute();
		s.person_assignment(a, 2);
		
		Debug.Log(a.hp);
		Debug.Log(a.attack);
	}

}
