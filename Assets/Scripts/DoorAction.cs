using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorAction : MonoBehaviour
{
    
    bool imIn = false;
    public GameObject door;
    

    private void OnTriggerEnter(Collider other)
    {
        imIn = true;
        
    }
    private void OnTriggerExit(Collider other)
    {
        imIn = false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (imIn)
        {
            if (Input.GetKeyDown("o"))
            {
                Debug.Log("Open");

                door.transform.Rotate(0f, -85f, 0f);
                Destroy(door.GetComponent<HingeJoint>());

            }
            else
            {
                if (Input.GetKeyDown("c"))
                {
                    Debug.Log("Close");
                }
            }
        }
    }
}
    