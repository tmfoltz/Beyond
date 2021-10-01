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
            SceneManager.LoadSceneAsync((int)ScenesIndices.MAIN, LoadSceneMode.Additive);
        }
    }

}
