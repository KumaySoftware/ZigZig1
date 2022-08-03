using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class menu : MonoBehaviour
{

    public GameObject leaderBoard1;
    public GameObject Shop;
    public GameObject bosbutton; //boþ button sonradan iþlev eklencek
    public GameObject Startbut;

    private void OnValidate()
    {
      //  Time.timeScale = 0;
    }
    // Start is called before the first frame update
    private void Start()
    {
       Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void Startbutton()
    {
            UnityEngine.Debug.Log("HOp");
            Time.timeScale = 1;
            leaderBoard1.SetActive(false);
            Shop.SetActive(false);
            bosbutton.SetActive(false);
            Startbut.SetActive(false);
    }
   












}
