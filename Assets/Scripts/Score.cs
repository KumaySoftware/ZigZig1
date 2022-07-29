using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score1;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score1 = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score1.ToString();
    }
}
