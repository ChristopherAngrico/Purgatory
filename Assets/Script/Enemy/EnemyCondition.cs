using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCondition : MonoBehaviour
{
    HealthSystem healthSystem;
    [HideInInspector] public bool isDying;
    [SerializeField] float adjustAnimatedTime;
    DetectPlayer detectPlayer;
    private void Awake()
    {
        if (gameObject.CompareTag("Minion"))
            healthSystem = new HealthSystem(20);
        if (gameObject.CompareTag("Boss1"))
            healthSystem = new HealthSystem(100);
        if (gameObject.CompareTag("Boss2"))
            healthSystem = new HealthSystem(100);
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
        print(healthSystem.currentHealth);
        if (healthSystem.currentHealth == 0)
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
