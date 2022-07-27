using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floor;
  
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
          SpawnTile();  
        }
        
    }

    void SpawnTile()
    {
        Vector3 direction;
        if (Random.Range(0,2) ==0)
        {
            direction = Vector3.forward;
        }
        else
        {
            direction=Vector3.left;
        }

       floor = Instantiate(floor,floor.transform.position+direction,floor.transform.rotation);
   
    
     }

}
