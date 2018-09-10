using System.Collections;
using System.Collections.Generic;
using System.IO;
using Script.Character;
using UnityEngine;

public class SearchTable  {

	List<string[]> csv;
	private string url = Application.absoluteURL;

	public SearchTable()
	{
	}

	public void init()
	{
		csv = new List<string[]>();
		StreamReader sr = new StreamReader(System.IO.Path.Combine(url, "Data.csv")); 
		string line;

		while ((line = sr.ReadLine()) != null)
		{
			csv.Add(line.Split(','));
		}
	}

	public void person_assignment(Attribute attribute,int Id)
	{
		attribute.attack = get(Id,3);
		attribute.hp = get(Id,2);
	}

	private int get(int y,int x)
	{
		return int.Parse(csv[y][x]);
	}
}

