using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade_Button : MonoBehaviour
{
    [SerializeField]private GameObject g_UpgradeButton;
    public void Upgrade_UI(){
        Time.timeScale = 0;
        g_UpgradeButton.SetActive(true);
    } 
    
}
