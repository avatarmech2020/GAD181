using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michael;

namespace Michael
{

    public class SlowingCollision : MonoBehaviour
    {
        public float slow;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                RobotCharacterController2D charController = other.gameObject.GetComponent<RobotCharacterController2D>();
                if (!charController.isSlowed)
                {
                    charController.isSlowed = true;
                    charController.maxSpeed = charController.maxSpeed * slow;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                RobotCharacterController2D charController = other.gameObject.GetComponent<RobotCharacterController2D>();
                if (charController.isSlowed)
                {
                    charController.isSlowed = false;
                    charController.maxSpeed = charController.maxSpeed * 2;
                }
            }
        }
    }
}