using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Json;
using TMPro;
using UnityEngine;

public class init : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		CharacterJson cj = new CharacterJson(Application.absoluteURL,"myPlayer");

		TextMeshProUGUI level = GameObject.Find("Character_Level_Text ").GetComponent<TextMeshProUGUI>();
		level.text = "level:"+cj.character.level.ToString();
		TextMeshProUGUI hp = GameObject.Find("Character_HP_Text").GetComponent<TextMeshProUGUI>();
		hp.text = "hp:" + (cj.character.level * 20).ToString();
		TextMeshProUGUI personality = GameObject.Find("Character_Personality_Text").GetComponent<TextMeshProUGUI>();
		personality.text = "person:" + cj.character.personality.ToString();
		
		
	}
}
