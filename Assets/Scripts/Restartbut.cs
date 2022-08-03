using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Restartbut : MonoBehaviour
{
    public void ReStartbutton()
    {
        SceneManager.LoadScene(0);
    }

}
