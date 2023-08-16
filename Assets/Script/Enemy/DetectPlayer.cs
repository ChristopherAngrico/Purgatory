using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    Collider2D playerDetect;
    [SerializeField] LayerMask playerLayer;
    [SerializeField] float circleRadius;
    [SerializeField] float adjustCenter;
    [HideInInspector] public bool triggerAttack;
    [HideInInspector] public bool isRunning;
    [HideInInspector] public bool idleState;
    [HideInInspector] public bool damagePlayer;

    private void FixedUpdate()
    {
        Detecting();
        MoveTowardPlayer();
        FlipSprite();
        // StartCoroutine(ColliderIsDisable());
    }
    private void Detecting()
    {
        playerDetect = Physics2D.OverlapCircle(transform.position + adjustCenter * Vector3.up, circleRadius, playerLayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + adjustCenter * Vector3.up, circleRadius);
        Gizmos.color = Color.green;
        if (playerDetect != null)
            Gizmos.DrawLine(transform.position, playerDetect.transform.position);
    }

    private void MoveTowardPlayer()
    {
        float speed = 5f;
        if (playerDetect != null && !triggerAttack && !idleState)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerDetect.transform.position, speed * Time.deltaTime);
            isRunning = true;
        }
        else
        {
            transform.position += Vector3.zero;
            isRunning = false;
        }
    }

    private void FlipSprite()
    {
        if (playerDetect != null)
        {
            if (transform.position.x < playerDetect.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (transform.position.x > playerDetect.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!idleState)
            {
                triggerAttack = true;
            }
        }
    }
    
    private void DamagePlayer()
    {
        GetComponentInChildren<HitPlayer>().enabled = true;
    }

    private void DisableCollider()
    {
        GetComponentInChildren<HitPlayer>().enabled = false;
    }
}