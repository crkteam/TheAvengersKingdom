using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneControll : MonoBehaviour {
	public GameObject scene1;
	private float mover;

	void Start ()
	{
		GameObject temp = GameObject.Instantiate(scene1);

		temp.transform.SetParent(GameObject.Find("Main_Background_Image").transform);
		
	}

// Update is called once per frame
	

	
}
