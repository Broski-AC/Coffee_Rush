using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMechanics : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        transform.localScale += new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            while (transform.localScale.y > 0.5)
            {
                transform.localScale += new Vector3(0, -0.5f, 0);
            }
        }
        else 
        {
            while (transform.localScale.y <= 0.5)
            {
                transform.localScale += new Vector3(0, 0.5f, 0);
            }
        }
    }
}


