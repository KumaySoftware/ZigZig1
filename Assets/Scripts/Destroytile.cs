using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroytile : MonoBehaviour
{
    //Start is called before the first frame update
    private void OnCollisionExit(Collision collision)
    {
        StartCoroutine(destroyTiles());
    }
    IEnumerator destroyTiles()
    {


        yield return new WaitForSeconds(4f);
        Destroy(gameObject);


    }


}
