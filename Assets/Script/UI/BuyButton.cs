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

        if (GameManager.instance.playerPoint >= 10 && !g_firstStage.activeSelf && !g_secondStage.activeSelf && !g_thirdStage.activeSelf)
        {
            g_firstStage.SetActive(true);
            GameManager.instance.playerPoint -= 10;
            playerHurt.shieldSystem.SetCurrentHealth(34);
            print(playerHurt.shieldSystem.GetHealth());
        }
    }
}
