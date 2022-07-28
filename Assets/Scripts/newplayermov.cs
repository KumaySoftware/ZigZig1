using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newplayermov : MonoBehaviour
{
    
        Vector3 playerMov;
        public float speed = 2;

        public FloorSpawner floorSpawner01;


        void Start()
        {
            playerMov = Vector3.forward;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (playerMov.x == 0)
                {
                    playerMov = Vector3.left;
                }
                else
                {
                    playerMov = Vector3.forward;
                }
            }
        }
        private void FixedUpdate()
        {

            Vector3 playerMoveSpeed = playerMov * Time.deltaTime * speed;
            transform.position += playerMoveSpeed;


        }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            floorSpawner01.Spawn_Single();
            //StartCoroutine(destroyTile(collision.gameObject));
        }
    }

    //IEnumerator destroyTile (GameObject DestroyedTile)
    //{


    //    yield return new WaitForSeconds(4f);
    //    Destroy(DestroyedTile);


    //}


}


