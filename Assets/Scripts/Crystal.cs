using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{

    public int crystal1;
    private int crystalCount; 
    private void OnTriggerEnter(Collider other)
    {

        crystalCount++;
        crystal1 = crystalCount;
        crystalCount = PlayerPrefs.GetInt("Crystal");
        PlayerPrefs.SetInt("Crystal", crystalCount);
        //CollectableControl.waterCount += 1;
        //  CollectableControl.collectedWater += CollectableControl.waterCount;
        this.gameObject.SetActive(false);
    }
}
