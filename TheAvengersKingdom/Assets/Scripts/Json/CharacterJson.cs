using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Json
{
    class CharacterJson : AbsCharacterJson
    {
        public Character character;

        public CharacterJson(string url,string name) { 
            string data = loadData(name, url);
            character = JsonConvert.DeserializeObject<Character>(data);
        }
        
        public void SetLevel(int data)
        {
            character.level = data;
        }

        public void SetName(String data)
        {
            character.name = data;
        }

        public void SetPersonality(int data) {
            character.personality = data;
        }

        public void Setcharacteristic(int data1,int data2,int data3, int data4, int data5)
        {
            character.characteristic[0] = data1;
            character.characteristic[1] = data2;
            character.characteristic[2] = data3;
            character.characteristic[3] = data4;
            character.characteristic[4] = data5;
        }

        public void Setcharacteristic_level(int data1, int data2, int data3, int data4, int data5)
        {
            character.characteristic_level[0] = data1;
            character.characteristic_level[1] = data2;
            character.characteristic_level[2] = data3;
            character.characteristic_level[3] = data4;
            character.characteristic_level[4] = data5;
        }

        public void Setskill(int data1, int data2, int data3, int data4, int data5)
        {
            character.skill[0] = data1;
            character.skill[1] = data2;
            character.skill[2] = data3;
            character.skill[3] = data4;
            character.skill[4] = data5;
        }

        public void Setskill_level(int data1, int data2, int data3, int data4, int data5) {
            character.skill_level[0] = data1;
            character.skill_level[1] = data2;
            character.skill_level[2] = data3;
            character.skill_level[3] = data4;
            character.skill_level[4] = data5;
        }

        public void Save(string url, string name) {
            string output = JsonConvert.SerializeObject(character);
            saveData(output,name,url);
        }
    }
}
