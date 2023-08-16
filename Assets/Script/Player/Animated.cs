using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Animated : MonoBehaviour
    {
        PlayerMovement playerMovement;
        Animator anim;
        PlayerHurt playerHurt;
        ThrowKnife throwKnife;
        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
            anim = GetComponent<Animator>();
            playerHurt = GetComponent<PlayerHurt>();
            throwKnife = GetComponentInChildren<ThrowKnife>();
        }
        public void FixedUpdate()
        {
            Idle();
            Running();
            Attack();
        }
        private void Idle()
        {
            if (!playerMovement.isRunning)
            {
                anim.SetBool("isRunning", false);
                anim.SetBool("Idle", true);
            }
        }
        private void Running()
        {
            if (playerMovement.isRunning)
            {
                anim.SetBool("Idle", false);
                anim.SetBool("isRunning", true);
            }
        }
        //TODO: attack animation
       
        private void Attack()
        {
            if (throwKnife.triggerAttack)
            {
                anim.SetTrigger("Attack");
                throwKnife.triggerAttack = false;
            }
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                throwKnife.isAttacking = true;
                PlayerInput.getPlayerInput.inputSystem.Player.Movement.Disable();
            }
            else if (throwKnife.isAttacking)
            {
                throwKnife.isAttacking = false;
                PlayerInput.getPlayerInput.inputSystem.Player.Movement.Enable();
            }
        }
        //Being call in the attack animation
        public void ThrowKnife(){
            throwKnife.throwKnife = true;
        }
        public void Die(){
            anim.SetTrigger("Die");
        }
    }
}