using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyClone : MonoBehaviour
{
    [SerializeField] private GameObject g_max;
    [SerializeField] private GameObject clone;
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }
    public void Buy()
    {
        Vector3 newPosition = Vector3.zero;
        if (player.transform.rotation == Quaternion.Euler(0, 0, 0))
        {
            newPosition = new Vector3(player.transform.position.x + 1f, player.transform.position.y, player.transform.position.z);
        }else{
            newPosition = new Vector3(player.transform.position.x - 1f, player.transform.position.y, player.transform.position.z);
        }
        g_max.SetActive(true);
        Instantiate(clone, newPosition, Quaternion.identity);
    }
}
