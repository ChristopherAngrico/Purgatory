using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class KnifeDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Minion"))
        {
            KnifeDamageLogic(10, other.gameObject);
        }
        if (other.gameObject.CompareTag("Boss1"))
        {
            KnifeDamageLogic(10, other.gameObject);
        }
        if (other.gameObject.CompareTag("Boss2"))
        {
            KnifeDamageLogic(5, other.gameObject);
        }
    }
    private int damageCheck;
    private void Update()
    {
        print(damageCheck);
    }
    private void KnifeDamageLogic(int damage, GameObject g)
    {
        int knifeDamage = damage + GameManager.instance.upgradeKnifeDamage;
        damageCheck = knifeDamage;
        g.GetComponent<EnemyCondition>().Damage(knifeDamage);
        Destroy(gameObject);// Destroy the knife after hit enemy
    }
}
