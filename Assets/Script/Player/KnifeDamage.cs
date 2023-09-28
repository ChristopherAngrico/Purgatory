using UnityEngine;

public class KnifeDamage : MonoBehaviour
{
    int knifeDamage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Minion"))
        {
            knifeDamage = 100 + GameManager.instance.upgradeKnifeDamage;
            other.GetComponent<EnemyCondition>().Damage(knifeDamage);
            Destroy(gameObject);// Destroy the knife after hit enemy
        }
        if(other.gameObject.CompareTag("Boss1")){
            knifeDamage = 100 + GameManager.instance.upgradeKnifeDamage;
            other.GetComponent<EnemyCondition>().Damage(knifeDamage);
            Destroy(gameObject);// Destroy the knife after hit enemy
        }
        if(other.gameObject.CompareTag("Boss2")){
            knifeDamage = 100 + GameManager.instance.upgradeKnifeDamage;
            other.GetComponent<EnemyCondition>().Damage(knifeDamage);
            Destroy(gameObject);// Destroy the knife after hit enemy
        }
    }

}
