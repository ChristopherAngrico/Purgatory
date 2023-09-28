using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyClone : MonoBehaviour
{
    [SerializeField] private GameObject g_maxlevel;
    [SerializeField] private GameObject g_clone;
    private bool buy;
    private void Update()
    {
        if (buy)
        {
            if (!g_clone.activeSelf)
            {
                g_maxlevel.SetActive(false);
                g_clone.SetActive(false);
                buy = false;
            }
        }
    }
    public void Buy()
    {
        if (!g_clone.activeSelf && GameManager.instance.playerPoint >= 100)
        {
            buy = true;
            g_maxlevel.SetActive(true);
            g_clone.SetActive(true);
            GameManager.instance.playerPoint -= 100;
        }
    }
}
