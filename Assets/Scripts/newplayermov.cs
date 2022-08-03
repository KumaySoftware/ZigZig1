using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newplayermov : MonoBehaviour
{
    public GameObject reStartbutton;
    public static bool camFollow;
    Vector3 playerMov;




    [SerializeField] float speed = 2;
    [SerializeField] bool isFall;
    public FloorSpawner floorSpawner01;
    [SerializeField] float scaleOfTime = 0f;
    [SerializeField] float scaleOfSpeed = 0.1f;
    [SerializeField] float Maxspeed = 7;


    void Start()
    {
        
        camFollow = true;
        isFall = false;
        playerMov = Vector3.forward;
    }


    void Update()
    {

        if (transform.position.y <= -0.3f)
        {
            isFall = true;
            camFollow = false;
            //Time.timeScale = 0;
            reStartbutton.SetActive(true);
            
        }


        if (isFall == true)
        {

            //Time.timeScale = scaleOfTime;
            return;

        }


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
            if (speed <= Maxspeed)
                speed += scaleOfSpeed * Time.deltaTime;
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
            Score.score1 += 1 ;
            collision.gameObject.AddComponent<Rigidbody>();
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


