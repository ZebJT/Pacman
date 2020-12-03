using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLifePac : MonoBehaviour
{
    public GameObject pacman;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject ghost1;
    Vector3 startPos;
    Vector3 ghost1startPos;
    int i = 0;

    void Start()
    {
         startPos = this.transform.position;
         ghost1startPos = ghost1.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            this.transform.position = startPos;
            ghost1.transform.position = ghost1startPos;
            i = i + 1;
            if (i == 1)
            {
                Debug.Log("You lost a life1");
                Destroy(life3);
            }
            else if (i == 2)
            {
                Debug.Log("You lost a life2");
                Destroy(life2);
            }
            else if (i == 3)
            {
                Debug.Log("You lost a life3");
                Destroy(life1);
            }
            else if (i == 4)
            {
                Debug.Log("You lost");
            }
        }
    }
}
