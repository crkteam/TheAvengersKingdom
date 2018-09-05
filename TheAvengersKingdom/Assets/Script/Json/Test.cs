using Assets.Scripts.Json;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using TMPro;
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
     //   cj.SetName("littleg");
       // cj.SetLevel(5);
        //cj.Setcharacteristic(5,4,3,2,1);
        //cj.Setcharacteristic_level(5, 4, 3, 2, 1);
        //cj.Setskill(5, 4, 3, 2, 1);
        //cj.Setskill_level(5, 4, 3, 2, 1);

        //cj.Save(Application.absoluteURL,"myPlayer");
		
	    TextMeshProUGUI Name = GameObject.Find("Character_Name_Text").GetComponent<TextMeshProUGUI>();
	    Name.text = "Name:" + cj.character.name.ToString(); 
	    TextMeshProUGUI level = GameObject.Find("Character_Level_Text").GetComponent<TextMeshProUGUI>();
	    level.text = "level:"+cj.character.level.ToString();
	    TextMeshProUGUI hp = GameObject.Find("Character_HP_Text").GetComponent<TextMeshProUGUI>();
	    hp.text = "hp:" + (cj.character.level * 20).ToString();
	    TextMeshProUGUI personality = GameObject.Find("Character_Personality_Text").GetComponent<TextMeshProUGUI>();
	    personality.text = "person:" + cj.character.personality.ToString();
    }
}
