using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneHealth : MonoBehaviour
{
     [SerializeField] private LayerMask enemyLayer;
    GameObject[] g_minions;
    GameObject[] g_bosses1;
    GameObject[] g_bosses2;
    
    void FixedUpdate()
    {
        g_minions = GameObject.FindGameObjectsWithTag("Minion");
        foreach (GameObject g_minion in g_minions)
        {
            if (g_minion != null)
            {
                if (g_minion.GetComponentInChildren<HitPlayer>().damagePlayer)
                {

                    g_minion.GetComponentInChildren<HitPlayer>().damagePlayer = false;
                    Destroy(gameObject);                   
                }
            }
        }
        g_bosses1 = GameObject.FindGameObjectsWithTag("Boss1");
        foreach (GameObject g_boss1 in g_bosses1)
        {
            if (g_boss1 != null)
            {
                if (g_boss1.GetComponentInChildren<HitPlayer>().damagePlayer)
                {
                    g_boss1.GetComponentInChildren<HitPlayer>().damagePlayer = false;
                    Destroy(gameObject);    
                }
            }
        }
        g_bosses2 = GameObject.FindGameObjectsWithTag("Boss2");
        foreach (GameObject g_boss2 in g_bosses2)
        {
            if (g_boss2 != null)
            {
                if (g_boss2.GetComponentInChildren<HitPlayer>().damagePlayer)
                {
                    g_boss2.GetComponentInChildren<HitPlayer>().damagePlayer = false;
                    Destroy(gameObject);    
                }
            }
        }
    }


}
