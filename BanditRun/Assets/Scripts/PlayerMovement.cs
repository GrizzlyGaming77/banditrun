using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animator>().SetTrigger("Run");
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().SetTrigger("Run");
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Animator>().SetTrigger("Attack");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("Jump");
        }
    }
}
