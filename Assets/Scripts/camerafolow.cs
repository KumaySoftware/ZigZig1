using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafolow : MonoBehaviour
{
    public Transform playerLocation;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - playerLocation.position;
    }

   
    void Update()
    {
        transform.position = fark + playerLocation.position;  
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

}
