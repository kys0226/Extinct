using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Go()
    {
        SceneManager.LoadScene("Game");
    }
    public void End()
    {
        SceneManager.LoadScene("Main");
    }
}
