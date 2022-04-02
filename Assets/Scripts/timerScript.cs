using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 40;
    float timeLeft;
    [SerializeField] private GameObject DeathPanel;

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
        }
    }
}
