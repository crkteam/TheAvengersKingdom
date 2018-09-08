using Assets.Scripts.Json;
using TMPro;
using UnityEngine;

namespace Script.Character
{
    public class MainCharacter
    {
        public Attribute attribute = new Attribute();
        SearchTable s = new SearchTable();
        CharacterJson cj = new CharacterJson(Application.absoluteURL, "myPlayer");
        private TextMeshProUGUI name;
        private TextMeshProUGUI hp;
        private TextMeshProUGUI level;

        public MainCharacter()
        {
            s.init();
            attribute.level = cj.character.level;
            attribute.name = cj.character.name;
            s.person_assignment(attribute, cj.character.personality);
            
           
        }

        public void init()
        {
            name = GameObject.Find("Character_Name_Text").GetComponent<TextMeshProUGUI>();
            hp = GameObject.Find("Character_HP_Text").GetComponent<TextMeshProUGUI>();
            level = GameObject.Find("Character_Level_Text").GetComponent<TextMeshProUGUI>();
            draw();
        }

        public void draw()
        {
            name.text = attribute.name;
            hp.text = attribute.hp.ToString();
            level.text = attribute.level.ToString();
        }
    }
}