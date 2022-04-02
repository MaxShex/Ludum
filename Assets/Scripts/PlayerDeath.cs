using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject DeathPanel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "death")
        {
            Time.timeScale = 0;
            DeathPanel.SetActive(true);
        }
    }
}
