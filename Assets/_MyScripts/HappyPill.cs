using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
    public class HappyPill : MonoBehaviour
    {
        public int pillvalue = 1;
        public bool isCollected = false;

        private void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "Player")
            {

                isCollected = true;
                PillManager.pills += pillvalue;
                Destroy(this.gameObject);
            }
        }
    }

}