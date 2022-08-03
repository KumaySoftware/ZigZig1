using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Crystal : MonoBehaviour
{
    public int crystalCount ;
    public TextMeshProUGUI crystalText;
    private static int crystal1;
     void Update()
    {
        crystalText.text = crystal1.ToString();
        //crystalCount = crystal1;
        //crystalText.text = crystalCount.ToString();
    }
    private void Awake()
    {
        crystalText.text = crystal1.ToString();
        crystal1 = PlayerPrefs.GetInt("Crystal");
    }
    private void OnTriggerEnter(Collider other)
    {

      
        //Debug.Log("crtstalcount"+ crystalCount);
        StartCoroutine(plusCrystal());
        //crystalText.text = crystal1.ToString();
        this.gameObject.SetActive(false);
    }


    private IEnumerator plusCrystal()
    {
         crystal1 += 1 ;
        PlayerPrefs.SetInt("Crystal", crystal1);
        yield return null;
    }
}
