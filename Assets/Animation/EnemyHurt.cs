using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyHurt : MonoBehaviour,IPointerDownHandler {
    private Animator animator2;

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
       GameObject Obj = GameObject.Find("Monster_Position").transform.GetChild(0).gameObject;
        animator2 = Obj.GetComponent<Animator>();
        animator2.SetTrigger("Hurt");
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
           
    }
}
