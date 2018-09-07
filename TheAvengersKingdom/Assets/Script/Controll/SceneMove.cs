using UnityEngine;
using UnityEngine.UI;

namespace Script.Controll
{
    public class SceneMove : MonoBehaviour
    {

        public Image background;
        public float speed;
        private float mover;

        private void Start()
        {
            Destroy(this,1f);
        }

        void Update()
        {
            mover = transform.position.x;
Debug.Log(mover);
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (mover <= -1500)
                background.color = Color.blue;
        }
    }
}