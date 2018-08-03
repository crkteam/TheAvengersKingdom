using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data : MonoBehaviour {

    List<string[]> a;
	// Use this for initialization
	void Start () {
        a = new List<string[]>();

        StreamReader sr = new StreamReader(System.IO.Path.Combine(Application.absoluteURL,"Data.csv"));
        string line;

        while((line = sr.ReadLine())!=null){
            a.Add(line.Split(','));
        }


        Debug.Log(a[2][0]);
	}
}
