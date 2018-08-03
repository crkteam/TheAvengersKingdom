using Assets.Scripts.Json;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using System.IO;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        test();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void test() {
        CharacterJson cj = new CharacterJson(Application.absoluteURL,"myPlayer");
        cj.SetName("陳博威");
        cj.SetLevel(5);
        cj.Setcharacteristic(5,4,3,2,1);
        cj.Setcharacteristic_level(5, 4, 3, 2, 1);
        cj.Setskill(5, 4, 3, 2, 1);
        cj.Setskill_level(5, 4, 3, 2, 1);

        cj.Save(Application.absoluteURL,"myPlayer");

        Debug.Log(cj.character.characteristic[0]);
    }
}
