using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndMenu : MonoBehaviour
{
    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
    // public void QuitGame()
    // {
    //     Application.Quit();
    // }
}
