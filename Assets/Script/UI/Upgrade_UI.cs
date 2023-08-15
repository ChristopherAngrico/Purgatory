using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade_UI : MonoBehaviour
{
    public void Canceled(){

        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
