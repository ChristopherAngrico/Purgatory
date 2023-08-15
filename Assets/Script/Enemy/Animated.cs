using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Enemy
{
    public class Animated : MonoBehaviour
    {
        private Animator anim;
        private DetectPlayer detectPlayer;
        private EnemyCondition enemyCondition;
        private void Awake()
        {
            anim = GetComponent<Animator>();
            detectPlayer = GetComponent<DetectPlayer>();
            enemyCondition = GetComponent<EnemyCondition>();
        }
        private void FixedUpdate()
        {
            Attack();
            Running();
            Die();
        }
        private void Attack()
        {
            if (detectPlayer.triggerAttack)
            {
                anim.SetTrigger("Attack");
                detectPlayer.triggerAttack = false;
                StartCoroutine(Idle());
            }
        }
        private IEnumerator Idle()
        {
            detectPlayer.idleState = true;
            float delay = gameObject.tag == "Boss2" ? 4 : 2;
            yield return new WaitForSeconds(delay);
            // GetComponent<CapsuleCollider2D>().enabled = true;
            detectPlayer.idleState = false;
        }
        private void Running()
        {
            anim.SetBool("Running", detectPlayer.isRunning);
        }

        private void Die()
        {
            if (enemyCondition.isDying)
            {
                anim.SetBool("Die", true);
            }
        }
    }
}