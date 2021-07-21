using System;
using Code.Models;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;
using UnityEngine.UI;

namespace Code.Controllers
{
    public class ButtonController : MonoBehaviour

    {
        private static int nr;
        private int myNr;
        private Random random = new Random();
        public TextField _myNumber = new TextField();
        public TextField _yourNumber = new TextField();
        public ButtonModel lower;
        public ButtonModel equal;
        public ButtonModel higher;


        private void Start()
        {
            nr = random.Next(2, 14);
            _myNumber.value += nr;
            myNr = random.Next(2, 14);
        }

        private void Awake()
        {
            
        }
    }
}