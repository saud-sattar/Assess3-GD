using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
     public void LoadLevelOne()
        {
            SceneManager.LoadScene("Level01");
        }
    
        public void LoadStartScene()
        {
            SceneManager.LoadScene("StartScene");
        }
}
