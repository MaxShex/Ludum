using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    int currentScene;
<<<<<<< Updated upstream
=======
    public GameObject NonPausedButton;
    public GameObject OnPauseButton;
>>>>>>> Stashed changes
    public void PauseButton()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
<<<<<<< Updated upstream
=======
        NonPausedButton.SetActive(false);
        OnPauseButton.SetActive(true);
>>>>>>> Stashed changes
    }
    public void ContinueButton()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
<<<<<<< Updated upstream
=======
        OnPauseButton.SetActive(false);
        NonPausedButton.SetActive(true);
>>>>>>> Stashed changes
    }
    
    public void RestartButton()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
        Time.timeScale = 1;
    }

<<<<<<< Updated upstream
    public void PlayButton()
    {
        SceneManager.LoadScene("test");
=======
    public void ReturnButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
>>>>>>> Stashed changes
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
