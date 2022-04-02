using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinesScript : MonoBehaviour
{
    
    public picker pickerScript;
    public timerScript timer;
    public float shrineAddsTime;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shrine")
        {
            if (Input.GetKeyDown(KeyCode.F) && timer.timeLeft >= timer.maxTime - shrineAddsTime && pickerScript.holdChecker)
            {
                timer.timeLeft = timer.maxTime - timer.timeLeft;
                
            } else if (Input.GetKeyDown(KeyCode.F) && timer.timeLeft <= timer.maxTime - shrineAddsTime && pickerScript.holdChecker)
            {
                timer.timeLeft += 5f;
            }
        }
    }
}
