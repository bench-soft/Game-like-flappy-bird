using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.UI
{
    public class GameOverPanel : MonoBehaviour
    {
       public void YesButtonClick()
        {
            GameManager.Instance.StartGame();
        }

        public void NoButtonlick()
        {
            GameManager.Instance.ReturnMenu();
        }
    }
}

