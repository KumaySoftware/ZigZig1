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

<<<<<<< Updated upstream
    void SpawnTile()
=======
    //public void SpawnTile()
    //{
    //    Vector3 direction;
    //    if (Random.Range(0,2) ==0)
    //    {
    //        direction = Vector3.forward;
    //    }
    //    else
    //    {
    //        direction=Vector3.left;
    //    }
    //    if (Random.Range(0, 10) == 0)
    //    {
    //        floor2 = Instantiate(floor2, floor.transform.position + direction, floor.transform.rotation);
    //        lastPosition = floor2.transform.position+ direction;
    //    }
    //    else
    //    {

    //        floor = Instantiate(floor, floor.transform.position + direction, floor.transform.rotation);
    //        lastPosition = floor.transform.position + direction;
    //    }
    //   //floor = Instantiate(floor,floor.transform.position+direction,floor.transform.rotation);
    // }

    public void Spawn_Single()
    {
        Spawn_Floor(Spawn_Chance());
       // StartCoroutine(destroyTiles());
    }

    private GameObject Spawn_Chance()
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
       floor = Instantiate(floor,floor.transform.position+direction,floor.transform.rotation);
   
    
     }
=======
        lastPosition = Instantiate(temp_floor, lastPosition, temp_floor.transform.rotation).transform.position;
    }

    //IEnumerator destroyTiles()
    //{


    //    yield return new WaitForSeconds(4f);
    //    Destroy(gameObject);


    //}
>>>>>>> Stashed changes

}
