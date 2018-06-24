using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{

    public class minmax : MonoBehaviour
    {
        protected int maxnum=100;
        protected int minnum=0;
        protected int sum = 0;
        // Use this for initialization
        void Start()
        {
            game();
            answer();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minnum = sum;
               
                answer();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxnum = sum;
                
                answer();
            }
        }
        private void game()
        {
            Debug.Log("Welcome");
            Debug.Log("Please Pick a number");
            Debug.Log("Higher number is:" + maxnum);
            Debug.Log("Lowest number is:" + minnum);

        }
        private void answer()
        {
            sum = (minnum + maxnum) / 2;
            Debug.Log("Is the number " + sum + " correct?");

        }
    }
}
