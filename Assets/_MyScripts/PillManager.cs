using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{
    public class PillManager : MonoBehaviour
    {
        public static int pills;
        Text pilltext;

        private void Awake()
        {
            pilltext = GetComponent<Text>();
            pills = 0;
        }


        private void Update()
        {
            pilltext.text = "Pills: " + pills;
        }
    }

}
