using Assets.Scripts.Json;
using TMPro;
using UnityEngine;

namespace Script.Character
{
    public class MainCharacter
    {
        public Attribute attribute = new Attribute();
        SearchTable s = new SearchTable();
        CharacterJson cj = new CharacterJson(Application.absoluteURL,"myPlayer");
        TextMeshProUGUI name = GameObject.Find("Character_Name_Text").GetComponent<TextMeshProUGUI>();
		TextMeshProUGUI hp = GameObject.Find("Character_HP_Text").GetComponent<TextMeshProUGUI>();
		TextMeshProUGUI level = GameObject.Find("Character_Level_Text").GetComponent<TextMeshProUGUI>();
        
        public MainCharacter()
        {
            
        }

        public void init()
        {
            s.init();
            attribute.level = cj.character.level;
            attribute.name = cj.character.name;
            s.person_assignment(attribute,cj.character.personality);
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