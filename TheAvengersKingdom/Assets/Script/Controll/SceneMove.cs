using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMove1 : MonoBehaviour {

	private GameObject background;
	
	public float speed;
	private float mover;

	private void Start()
	{
		Destroy(gameObject,1f);
	}

	void Update()
	{

		background=GameObject.Find("Main_Background_Image");
		mover = transform.position.x;
		Debug.Log(mover);
		transform.Translate(Vector3.left * Time.deltaTime * speed);
		if (mover <= -1500)
			background.GetComponent<Image>().color=Color.blue;

	}
}
