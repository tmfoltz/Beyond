using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Beyond
{
    public class GameManager : MonoBehaviour
    {
        
        public static GameManager _instance;

        public void Awake()
        {
            _instance = this;
            SceneManager.LoadSceneAsync((int)ScenesIndices.MAIN_MENU, LoadSceneMode.Additive);
        }

        public void LoadGame()
        {
            SceneManager.UnloadSceneAsync((int)ScenesIndices.MAIN_MENU);
            SceneManager.LoadSceneAsync((int)ScenesIndices.GAME, LoadSceneMode.Additive);
        }
    }

}
