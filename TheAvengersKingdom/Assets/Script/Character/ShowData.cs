using Assets.Scripts.Json;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Character
{
    public class ShowData : MonoBehaviour
    {
        private void Start()
        {
          
            Text name = GameObject.Find("Character_Name_Text").GetComponent<Text>();
            Text hp = GameObject.Find("Character_Level_Text").GetComponent<Text>();
            Text level = GameObject.Find("Character_HP_Text").GetComponent<Text>();

            name.text ="姓名:" +GameController.Instance.mc.attribute.name;
            hp.text ="等級:"+ GameController.Instance.mc.attribute.hp.ToString();
            level.text ="血量:"+ GameController.Instance.mc.attribute.level.ToString();
        }
    }
}