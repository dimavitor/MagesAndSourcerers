using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{

    public static void LoadLevel(int level)
    {
        SceneManager.LoadScene(1);
    }
    public static void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

}
