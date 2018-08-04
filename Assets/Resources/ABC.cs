using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABC : ChangeFace {

	// Use this for initialization
	public void OnBtnHair()
    {
        
        hair++;
        if (hair > 3)
            hair = 1;
        Change("b", "hair", hair);
        Debug.Log(hair);
    }
    public void OnBtnEye()
    {
        
        eye--;
        if (eye < 1)
            eye = 3;
        Change("a", "eye", eye);
    }

}
