using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        Cursor.lockState = CursorLockMode.None;
        //Press the space bar to apply no locking to the Cursor
       /*
         if (Input.GetKey(KeyCode.Space))
        {
           Cursor.lockState = CursorLockMode.None;
        }
        */
    }
}
