using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConvert : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("GamePlay1");
    }

    public void Scene2()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Scene3()
    {
        SceneManager.LoadScene("GamePlay2");
    }
       
}
