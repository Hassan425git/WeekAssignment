using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public enum SceneNames {Gameplay1, Gameplay2 };
    
    public void LevelLoaded1(int scenename)
    {
         SceneManager.LoadScene(SceneNames.Gameplay1.ToString());
    }

    public void LevelLoaded2(int scenename)
    {
        SceneManager.LoadScene(scenename);
        SceneManager.LoadScene(SceneNames.Gameplay2.ToString());
    }

    public void Loadscene()
    {
           SceneManager.LoadScene(SceneNames.Gameplay1.ToString());
    }
    

}
