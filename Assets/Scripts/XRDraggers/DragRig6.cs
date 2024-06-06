using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRig6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject XrRig;

    private Vector3 viewSpot;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            viewSpot = this.transform.position + new Vector3(0.2f, 0, 0);
            viewSpot[1] = -0.45f;

            Debug.Log(viewSpot);

            XrRig.transform.position = viewSpot;
        }
    }
}
