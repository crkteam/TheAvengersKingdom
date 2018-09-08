using UnityEngine;

namespace Script.Character
{
    public class GameController
    {
        public static GameController instance;
        public MainCharacter mc=new MainCharacter();
        [HideInInspector]
        public static GameController Instance
        {
            get
            {
                if (instance==null)
                {
                    instance=new GameController();
                }

                return instance;
            }
        
           
        }

        void Start()
        {
            mc.init();
        }
        
        


    }
}