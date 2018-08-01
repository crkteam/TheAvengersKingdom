using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Json
{
    interface BaseJson
    {
        void saveData(string output,string name,string url);
        String loadData(string name,string url);
    }
}
