using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    [SerializeField] GameObject floor;
    [SerializeField] GameObject floor2;
    [SerializeField] GameObject floor3;
    Vector3 lastPosition;

    [SerializeField] List<GameObject> floors;

    [SerializeField, Range(0, 100)] int spawn_amount = 20;

    void Start()
    {
        lastPosition = floor.transform.position;

        if (floors.Count <= 0)
        {
            Debug.Log("!!! Floor List is EMPTY !!!");
            Debug.Break();
        }

        //for (int i = 0; i < spawn_amount; i++)
        //  SpawnTile();

        for (int i = 0; i < spawn_amount; i++)
            Spawn_Floor(Spawn_Chance());
    }

    //void SpawnTile()

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

    {
        float spawn_chance = Random.Range(0, 100);

        if (spawn_chance <= 10)
        {
            //Floor2
            return floor2;
        }
        else
        {
            //Original Floor
            return floor3;
        }

    }
    private void Spawn_Floor(GameObject temp_floor)
    {
        Vector3 direction = Random.Range(0, 2) == 0 ? Vector3.forward : Vector3.left;
        lastPosition += direction;

        lastPosition = Instantiate(temp_floor, lastPosition, temp_floor.transform.rotation).transform.position;
    }
}