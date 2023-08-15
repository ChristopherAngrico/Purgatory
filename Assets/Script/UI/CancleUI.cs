using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeUI : MonoBehaviour
{
    [SerializeField]GameObject g_UpgradeUI;
    public void Canceled(){
        gameObject.SetActive(false);
        Time.timeScale = 1;
        g_UpgradeUI.SetActive(false);
    }
}
