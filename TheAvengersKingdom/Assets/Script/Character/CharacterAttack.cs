using System.Collections;
using System.Collections.Generic;
using Script.Character;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAttack : MonoBehaviour {

    public Animator animator;
    public Slider s;
    float num = 100f;
    public float enemyhp;
    private float NowEnemyhp;
    
    void Start()
    {
     
        s.value = s.maxValue;
        NowEnemyhp = enemyhp;
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
                NowEnemyhp -= GameController.Instance.mc.attribute.attack;
                s.value = NowEnemyhp / enemyhp  * 100;
                Debug.Log (s.value);
                if (num <= 0)
                {
                    num = 100f;
                }
             
            }  
        }
    }
}
