using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneControll : MonoBehaviour {
	public Image scene1;
	public Image background;
	public float speed;
	private float mover;
	Vector3 goal=new Vector3(0f,0f,0f);
	private Vector3 pos=new Vector3();


	void Start ()
	{
   
	}

// Update is called once per frame
	void Update ()
	{


		mover = scene1.rectTransform.position.x;
		if(mover>-3000)
			scene1.transform.Translate(Vector3.left * Time.deltaTime * speed);
		if(mover<=-1500)
			background.color=Color.blue;
		
		else
		{

		
       
		}
   
	}
}
