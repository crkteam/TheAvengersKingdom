using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFace : MonoBehaviour
{
    public int hair = 1;
    public int eye = 1;
    // Use this for initialization
   public void Change(string ImageName, string Part,int num)
    {
        
            Image g = GameObject.Find("Image/"+Part).GetComponent<Image>();
            g.sprite = Resources.Load<Sprite>(ImageName + num.ToString());
        
      
    }
}
    



