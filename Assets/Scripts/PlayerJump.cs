using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 2.0f;

    Rigidbody rb;

    Vector3 jump;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            
            Debug.Log("Salto");
        }
    }
}
