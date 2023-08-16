using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCondition : MonoBehaviour
{
    HealthSystem healthSystem;
    [HideInInspector] public bool isDying;
    DetectPlayer detectPlayer;
    private void Awake()
    {
        //Assign enemy health
        int minionHealth = 20;
        int boss1Health  = 100;
        int boss2Health = 100;

        if (gameObject.CompareTag("Minion"))
            healthSystem = new HealthSystem(minionHealth, false);
        if (gameObject.CompareTag("Boss1"))
            healthSystem = new HealthSystem(boss1Health, false);
        if (gameObject.CompareTag("Boss2"))
            healthSystem = new HealthSystem(boss2Health, false);
    }
    private void Start()
    {
        detectPlayer = GetComponent<DetectPlayer>();
       
    }

    public void Damage(int knifeDamage)
    {
        healthSystem.Damage(knifeDamage);
    }

    private void FixedUpdate()
    {
        if (healthSystem.GetHealth() == 0)
        {
            detectPlayer.enabled = false;
            StartCoroutine(Animated());
        }
    }

    private IEnumerator Animated()
    {
        isDying = true;
        GetComponent<CapsuleCollider2D>().enabled = false;
        yield return new WaitForSeconds(2);
        if (gameObject.tag == "Boss2")
        {
            yield return new WaitForSeconds(1);
            GameManager.instance.Finished();
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
