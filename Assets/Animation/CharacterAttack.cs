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
            animator.SetTrigger("Hit");
            if (num >= 0)
            {
//                NowEnemyHp -= GameController.Instance.mc.attribute.attack;
                s.value = NowEnemyHp / EnemyHp * 100;
                Debug.Log(NowEnemyHp);
                if (num <= 0)
                {
                    num = 100f;
                }
            }

            else
            {
                s.value = 0;
            }

    }
}
