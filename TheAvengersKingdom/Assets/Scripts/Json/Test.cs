using Assets.Scripts.Json;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        test();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void test() {
        People ouput = new People();
        ouput.Name = "劉政豪";
        ouput.Id = 05130401;
        ouput.Habit = "打球";

        string output = JsonConvert.SerializeObject(ouput);
        Debug.Log(output);

        People input = JsonConvert.DeserializeObject<People>(output);
        Debug.Log("ID : " + input.Id);
        Debug.Log("Name : " + input.Name);
        Debug.Log("Author : " + input.Habit);
    }
}
