using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private GameObject g_firstStage;
    [SerializeField] private GameObject g_secondStage;
    [SerializeField] private GameObject g_thirdStage;
    [SerializeField] private PlayerHurt playerHurt;
    private int upgradeKnifeDamage = 10;
    private int upgradeShield = 34;
    public void Upgrade_Blade()
    {

        // SecondStage
        if (GameManager.instance.playerPoint >= 15 && g_firstStage.activeSelf)
        {
            GameManager.instance.playerPoint -= 15;
            g_firstStage.SetActive(false);
            g_secondStage.SetActive(true);
            GameManager.instance.upgradeKnifeDamage += upgradeKnifeDamage;
        }
        // ThirdStage
        else if (GameManager.instance.playerPoint >= 30 && g_secondStage.activeSelf)
        {
            GameManager.instance.playerPoint -= 30;
            g_secondStage.SetActive(false);
            g_thirdStage.SetActive(true);
            GameManager.instance.upgradeKnifeDamage += upgradeKnifeDamage;
        }
    }
    public void Upgrade_Shield()
    {

        // SecondStage
        if (GameManager.instance.playerPoint >= 10 && g_firstStage.activeSelf)
        {
            GameManager.instance.playerPoint -= 10;
            g_firstStage.SetActive(false);
            g_secondStage.SetActive(true);
            playerHurt.shieldSystem.SetCurrentHealth(upgradeShield);
        }
        // ThirdStage
        else if (GameManager.instance.playerPoint >= 10 && g_secondStage.activeSelf)
        {
            GameManager.instance.playerPoint -= 10;
            g_secondStage.SetActive(false);
            g_thirdStage.SetActive(true);
            playerHurt.shieldSystem.SetCurrentHealth(upgradeShield);
        }
    }
}
