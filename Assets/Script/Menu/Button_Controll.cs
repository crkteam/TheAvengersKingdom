using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Controll : MonoBehaviour {
    public GameObject CharButton;
    void Start()
    {
        CharButton.SetActive(false);

    }
    public void ButtonChar()
    {   //控制顯示和隱藏的方法
        if (!CharButton.activeInHierarchy)
        {
            CharButton.SetActive(true);
        }
        else
        {
            CharButton.SetActive(false);
        }
    }
}
