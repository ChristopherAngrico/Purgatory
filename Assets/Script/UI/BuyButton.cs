using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    [SerializeField] PlayerHurt playerHurt;
    [SerializeField] GameObject g_firstStage;
    [SerializeField] GameObject g_secondStage;
    [SerializeField] GameObject g_thirdStage;

    public void Buy()
    {

        if (!g_firstStage.activeSelf && !g_secondStage.activeSelf && !g_thirdStage.activeSelf)
        {
            g_firstStage.SetActive(true);
            playerHurt.shieldSystem.currentHealth += 66;
        }


    }
}
