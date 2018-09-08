using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Json
{
    abstract class AbsCharacterJson : BaseJson
    {
        public string loadData(string name,string url)
        {
            StreamReader inputfile = new StreamReader(System.IO.Path.Combine(url, name));
            string Data = inputfile.ReadToEnd();
            inputfile.Close();

            return Data;
        }

        public void saveData(string output,string name,string url)
        {
            StreamWriter outfile = new StreamWriter(System.IO.Path.Combine(url, name));
            outfile.Write(output);
            outfile.Close();
        }
    }
}
