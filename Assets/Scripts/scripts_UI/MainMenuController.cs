using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Beyond
{
    public class MainMenuController : MonoBehaviour
    {
        GameManager gameManager;
        void Awake()
        {
            gameManager = GameManager._instance ;
        }

        public void StartGame()
        {
            gameManager.LoadGame();
        }
    }
}
