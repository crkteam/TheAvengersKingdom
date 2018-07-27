using Assets.Scripts.Json;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        test();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void test() {

        Man FarBoy = new Man();
        FarBoy.dick = 3;
        FarBoy.ball = 0;
        string test = JsonConvert.SerializeObject(FarBoy);
        Debug.Log(test);


        Class c = new Class();

        People ouput = new People();
        ouput.Name = "劉政豪";
        ouput.Id = 05130401;
        ouput.Habit.Add("帥");
        ouput.Habit.Add("酷");
        ouput.Habit.Add("猛");

        People ouput2 = new People();
        ouput2.Name = "陳博威";
        ouput2.Id = 05133065;
        ouput2.Habit.Add("醜");
        ouput2.Habit.Add("宅");
        ouput2.Habit.Add("窮");

        People ouput3 = new People();
        ouput3.Name = "鄒政憲";
        ouput3.Id = 05138065;
        ouput3.Habit.Add("大");
        ouput3.Habit.Add("蛇");
        ouput3.Habit.Add("丸");

        c.People.Add(ouput);
        c.People.Add(ouput2);
        c.People.Add(ouput3);

        string output = JsonConvert.SerializeObject(c);
        Debug.Log(output);

        //

        Class input = JsonConvert.DeserializeObject<Class>(output);
        Debug.Log("ID : " + input.People[2].Habit[1]);

        Man get = JsonConvert.DeserializeObject<Man>(test);
        Debug.Log(get.dick);

    }
}
