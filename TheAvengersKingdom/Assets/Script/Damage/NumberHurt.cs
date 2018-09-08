using System.Collections;
using System.Collections.Generic;
using Script.Character;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class NumberHurt : MonoBehaviour
{
    public GameObject prefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //按A键，模拟Cube受伤
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject temp = GameObject.Instantiate(prefab);
            //将游戏对象temp作为Canvas的子物体
            temp.transform.SetParent(GameObject.Find("Menu_Monster_DamageHP").transform);
            temp.transform.position = GameObject.Find("Menu_Monster_DamageHP").transform.position;
            //血量文本提示是UI控件，和Cube坐在的坐标系不是同一套，因此我们需要将血量产生点(Cube的位置)从世界坐标系转化成屏幕坐标系。为了上Cube的上方产生，我们可以在y周上给一个适量的偏移

            //假设当前的血量是Cube受攻击丢的血量
            temp.GetComponent<Text>().text =GameController.instance.mc.attribute.attack.ToString();
            
        }
    }
}