using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyHurt : MonoBehaviour,IPointerDownHandler {
    public Animator animator2;

    public void OnPointerDown(PointerEventData eventData)
    {
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
