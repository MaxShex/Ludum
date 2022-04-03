using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    int currentScene;
    public void PauseButton()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }
    public void ContinueButton()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
    
    public void RestartButton()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
        Time.timeScale = 1;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("test");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
