using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
   public void Setup()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("GamePlay");
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
