using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picker : MonoBehaviour
{
    public bool holdChecker;
    public float distance =3f;
    RaycastHit2D hit;
    public Transform hands;
    public float objectThrow =3;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!holdChecker)
            {
                Physics2D.queriesStartInColliders = false;
               hit =  Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);

                if (hit.collider != null && hit.collider.tag == "tribute")
                {
                    holdChecker = true;
                }
            }
            else
            {
                holdChecker = false;
                if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * objectThrow;
                }
            }
        }
        if (holdChecker)
        {
            hit.collider.gameObject.transform.position = hands.position;

        }
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position +  Vector3.right * transform.localScale.x * distance);
    }
}
