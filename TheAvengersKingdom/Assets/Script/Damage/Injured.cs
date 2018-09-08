using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injured : MonoBehaviour {

    //血量移动的速度
    public float speed = 100;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //血量移动的效果
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}