using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Controll : MonoBehaviour {
    public GameObject CharButton;
    void Start()
    {
        CharButton.active = false;

    }
    public void ButtonChar()
    {   //控制顯示和隱藏的方法
        if (CharButton.active == false)
        {
            CharButton.SetActive(true);
        }
        else
        {
            CharButton.SetActive(false);
        }
    }
}
