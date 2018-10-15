using System.Collections;
using System.Collections.Generic;
using Script.Character;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterAttack : MonoBehaviour,IPointerDownHandler {

    public Animator animator;
    public Slider s;
    float num = 100f;
    public float EnemyHp;
    float NowEnemyHp;
    private MainCharacter mc;
    public GameObject prefab;
    public GameObject Hp_slider;
    void Start()
    {
        NowEnemyHp = EnemyHp;
        s.value = s.maxValue;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        mc = new MainCharacter(Application.absoluteURL);
        animator.SetTrigger("Hit");
            if (s.value >= 0)
            {

                NowEnemyHp -= mc.attribute.attack;
                s.value = NowEnemyHp / EnemyHp * 100;
                Debug.Log(NowEnemyHp);
                if (s.value <= 0)
                {
                  
                    Hp_slider.SetActive(false);
                    NowEnemyHp = EnemyHp;
                 Destroy(GameObject.Find("Monster_Position").transform.GetChild(0).gameObject);   
                 Invoke("CreatMonster",1f);
                    
                 
                }
            }

            else
            {
                s.value = 0;
            }

    }

    void CreatMonster()
    {
        
        Hp_slider.SetActive(true);
        GameObject temp = GameObject.Instantiate(prefab);
        //将游戏对象temp作为Canvas的子物体
        temp.transform.SetParent(GameObject.Find("Monster_Position").transform);
        temp.transform.position = GameObject.Find("Monster_Position").transform.position;
      
        NowEnemyHp = EnemyHp;
        s.value = 100f;
    }
}
