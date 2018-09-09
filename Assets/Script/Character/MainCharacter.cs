using Assets.Scripts.Json;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Character
{
    public class MainCharacter
    {
        public Attribute attribute = new Attribute();
        SearchTable s = new SearchTable();
        CharacterJson cj = new CharacterJson(Application.absoluteURL, "myPlayer");
        private Text name;
        private Text hp;
        private Text level;

        public MainCharacter()
        {
            s.init();
            attribute.level = cj.character.level;
            attribute.name = cj.character.name;
            s.person_assignment(attribute, cj.character.personality);
        }


        public void draw()
        {
            name = GameObject.Find("Character_Name_Text").GetComponent<Text>();
            hp = GameObject.Find("Character_Level_Text").GetComponent<Text>();
            level = GameObject.Find("Character_HP_Text").GetComponent<Text>();

            name.text = attribute.name;
            hp.text = attribute.hp.ToString();
            level.text = attribute.level.ToString();
        }
    }
}