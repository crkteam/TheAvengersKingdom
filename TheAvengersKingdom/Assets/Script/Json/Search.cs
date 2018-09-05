using System.IO;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Security.AccessControl;
using Assets.Scripts.Json;
using Boo.Lang;
using Script.Json;
using UnityEngine;

namespace Script.Charater
{
    public class Search
    {
        void start()
        {
        }
        List<string[]> a;
        private int select;
        private string get(int type, int kind)
        {
            a = new List<string[]>();
            StreamReader csv = new StreamReader(System.IO.Path.Combine(Application.absoluteURL, "personal2.csv"));
            string line;

            while ((line = csv.ReadLine()) != null)
            {
                a.Add(line.Split(','));
            }

            for (int i = 1; 1 <= a[i].Length; i++)
            {
                if (a[i][0] == type.ToString())
                {
                    return a[i][kind + 1];
                }
            }

            return "";
        }

        attribute SetCharacter(attribute data, int type, int kind)
        {
            CharacterJson cj = new CharacterJson(Application.absoluteURL, "myPlayer");
            data.personality = cj.character.personality;
            a = new List<string[]>();
            
            StreamReader csv = new StreamReader(System.IO.Path.Combine(Application.absoluteURL, "personal.csv"));
            string line;
            while ((line = csv.ReadLine()) != null)
            {
                a.Add(line.Split(','));
            }

            for (int i = 1; i < a.Count; i++)
            {
                if (data.personality==int.Parse(a[i][0]))
                {
                    select = i;
                    break;
                    
                }
                
            }

            data.name = cj.character.name;
            data.level = cj.character.level;
            data.Attack = int.Parse(a[select][2])* int.Parse(get(data.personality, 3));
            data.Defend = int.Parse(a[select][3]) * int.Parse(get(data.personality, 4));
            data.characteristic = cj.character.characteristic;
            data.characteristic_level = cj.character.characteristic_level;
            data.skill = cj.character.skill;
            data.skill_level = cj.character.skill_level;
            return data;
        }
    }
}