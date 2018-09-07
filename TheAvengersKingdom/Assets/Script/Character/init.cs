using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Json;
using Script.Character;
using TMPro;
using UnityEngine;

public class init : MonoBehaviour
{
	
	void Start()
	{
		MainCharacter mc = new MainCharacter();
		mc.init();
	}
}
