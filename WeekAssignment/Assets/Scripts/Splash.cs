using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
   
    public enum SceneNames {Splash, Menu, Gameplay};

    void Start()
    {
        StartCoroutine(Loadscene());
    }

    
    IEnumerator Loadscene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneNames.Menu.ToString());
    }

   


}
