using System.Collections;
using System.Collections.Generic;
using Script.Character;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAttack : MonoBehaviour {

    public Animator animator;
    public Slider s;
    float num = 100f;
    public float EnemyHp;
    float NowEnemyHp;


    void Start()
    {
        NowEnemyHp = EnemyHp;
        s.value = s.maxValue;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            animator.SetTrigger("Hit");


            if (num >= 0)
            {
                NowEnemyHp-= GameController.Instance.mc.attribute.attack;
                s.value = NowEnemyHp / EnemyHp * 100;
                Debug.Log (NowEnemyHp);
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
}
