using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 15);
            player.transform.rotation = Quaternion.identity;
            player.transform.Rotate(0.0f, -90.0f, 0.0f);
        }

        if (Input.GetKeyDown("a"))
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
            player.transform.rotation = Quaternion.identity;
            player.transform.Rotate(0.0f, 0.0f, 180.0f);
        }

        if (Input.GetKeyDown("s"))
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -15);
            player.transform.rotation = Quaternion.identity;
            player.transform.Rotate(0.0f, 90.0f, 0.0f);
        }

        if (Input.GetKeyDown("d"))
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
            player.transform.rotation = Quaternion.identity;
        }
    }
}
