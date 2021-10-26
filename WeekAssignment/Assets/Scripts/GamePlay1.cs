using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay1 : MonoBehaviour
{
    public enum SceneNames { Gameplay2 };

    public void LevelLoaded(int scenename)
    {
        SceneManager.LoadScene(SceneNames.Gameplay2.ToString());

        
    }

}
