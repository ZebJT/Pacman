using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreScript.scoreValue += 1;
            Destroy(gameObject);
        }
    }
}
