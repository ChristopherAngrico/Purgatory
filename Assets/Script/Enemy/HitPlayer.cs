using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{

    BoxCollider2D box;
    PolygonCollider2D polygon;
    [HideInInspector] public bool damagePlayer, damageClone;
    private void OnEnable()
    {
        if (transform.parent.CompareTag("Boss1"))
        {
            box = GetComponentInChildren<BoxCollider2D>();
            box.enabled = true;
        }
        if (transform.parent.CompareTag("Boss2") || transform.parent.CompareTag("Minion"))
        {
            polygon = GetComponentInChildren<PolygonCollider2D>();
            polygon.enabled = true;
        }
    }
    private void OnDisable()
    {
        if (transform.parent.CompareTag("Boss1"))
        {
            box.enabled = false;
        }
        if (transform.parent.CompareTag("Boss2") || transform.parent.CompareTag("Minion"))
        {
            polygon.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Clone"))
        {

            damagePlayer = true;
            if (GameObject.FindWithTag("Clone") != null)
            {
                damageClone = true;
            }
        }
    }
}
