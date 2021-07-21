using System;
using Code.Models;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;

namespace Code.Controllers
{
    public class ButtonFuncitonality : MonoBehaviour

    {
        private static int nr;
        private int myNr;
        private Random random = new Random();
        public TextField _myNumber;
        public TextField _yourNumber;
        public ButtonModel lower;
        public ButtonModel equal;
        public ButtonModel higher;
        
        
        void Start()
        {
            nr = random.Next(2,14);
            _myNumber.value += nr;
            myNr = random.Next(2,14);
        }
        
    }
}
