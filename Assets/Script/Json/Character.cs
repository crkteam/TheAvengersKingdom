using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Json
{
    class Character
    {
        public String name;
        public int level;
        public int personality;
        public int[] characteristic = new int[5];
        public int[] characteristic_level = new int[5];
        public int[] skill = new int[5];
        public int[] skill_level = new int[5];
    }
}
