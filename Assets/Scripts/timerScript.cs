using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 40;
    public float timeLeft;
    [SerializeField] private GameObject DeathPanel;
    picker pickerScript;

    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime; 
    }

    
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;

        } else
        {
            DeathPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
