using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinesScript : MonoBehaviour
{
    
    public picker pickerScript;
    public timerScript timer;
    public float shrineAddsTime;
    private Rigidbody2D rb;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject tribute;

    private Animator anim;
    public bool spawn = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = transform.GetChild(0).GetComponent<Animator>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shrine" && spawn == true)
        {
            if ( timer.timeLeft >= timer.maxTime - shrineAddsTime )
            {
                timer.maxTime = timer.maxTime - 3;
                timer.timeLeft += timer.maxTime - timer.timeLeft;

                Instantiate(tribute, spawnPoint.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                Destroy(gameObject);
                
                spawn = false;
                

            } else if ( timer.timeLeft <= timer.maxTime - shrineAddsTime  )
            {
                timer.maxTime = timer.maxTime - 3;
                timer.timeLeft += shrineAddsTime;
                Instantiate(tribute, spawnPoint.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                Destroy(gameObject);

                
                spawn = false;

            }
        }
        if (collision.gameObject.tag == "SecondShrine" && spawn == false)
        {
            if (timer.timeLeft >= timer.maxTime - shrineAddsTime )
            {
                timer.maxTime = timer.maxTime - 3;
                timer.timeLeft += timer.maxTime - timer.timeLeft;

                Instantiate(tribute, spawnPoint.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                Destroy(gameObject);
                pickerScript.holdChecker = false;
                
                spawn = true;

            }
            else if (timer.timeLeft <= timer.maxTime - shrineAddsTime )
            {
                timer.maxTime = timer.maxTime - 3;
                timer.timeLeft += shrineAddsTime;
                Instantiate(tribute, spawnPoint.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                Destroy(gameObject);
                
                spawn = true;

            }
        }
    }
}
