using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay2 : MonoBehaviour
{
    
    public void LevelLoaded(int scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
