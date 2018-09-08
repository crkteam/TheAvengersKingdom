using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAttack : MonoBehaviour {

    public Animator animator;
    public Slider s;
    float num = 100f;


    void Start()
    {
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
                num = num - 10.0f;
                s.value = num;
                if (num == 0)
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
