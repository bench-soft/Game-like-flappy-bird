using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Controller
{
    public class PcInputKontroller 
    {
        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool RightMouseClickDown => Input.GetMouseButtonDown(1);
    }
}

