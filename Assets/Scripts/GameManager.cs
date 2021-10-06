using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Beyond
{
    public class GameManager : MonoBehaviour
    {
        
        public static GameManager _instance;
        public bool MainMenuLoaded;

        public void Awake()
        {
            _instance = this;
            SceneManager.LoadSceneAsync((int)ScenesIndices.MAIN_MENU, LoadSceneMode.Additive);
            MainMenuLoaded = false;
        }

        public void Update()
        {
            if (!MainMenuLoaded)
            {
                if (SceneManager.GetSceneByBuildIndex((int)ScenesIndices.MAIN_MENU).isLoaded)
                {
                    SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex((int)ScenesIndices.MAIN_MENU));
                    MainMenuLoaded = true ;
                }
            }
        }

        public void LoadGame()
        {
            SceneManager.UnloadSceneAsync((int)ScenesIndices.MAIN_MENU);
            SceneManager.LoadSceneAsync((int)ScenesIndices.GAME, LoadSceneMode.Additive);
        }
    }

}
