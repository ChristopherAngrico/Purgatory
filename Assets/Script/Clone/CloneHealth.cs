using Clone;
using UnityEngine;

public class CloneHealth : MonoBehaviour
{
    GameObject[] g_minions;
    GameObject[] g_bosses1;
    GameObject[] g_bosses2;
    HealthSystem healthSystem;
    [SerializeField] GameObject g_health;
    [HideInInspector] public bool isDying;
    private void OnEnable()
    {
        int healthMax = 30;
        healthSystem = new HealthSystem(healthMax, false);
        g_health.transform.localScale = new Vector3(healthSystem.GetHealth(),1,1);
    }
    void FixedUpdate()
    {
        DamageReceivedByEnemy();
        //Player Die
        Die();
    }

    private void DamageReceivedByEnemy()
    {
        int damageReceivedByMinion = 14;
        int damageReceivedByBoss1 = 40;
        int damageReceivedByBoss2 = 40;

        g_minions = GameObject.FindGameObjectsWithTag("Minion");
        GettingHitByEnemy(g_minions, damageReceivedByMinion);

        g_bosses1 = GameObject.FindGameObjectsWithTag("Boss1");
        GettingHitByEnemy(g_bosses1, damageReceivedByBoss1);

        g_bosses2 = GameObject.FindGameObjectsWithTag("Boss2");
        GettingHitByEnemy(g_bosses2, damageReceivedByBoss2);
    }

    private void GettingHitByEnemy(GameObject[] g_Enemies, int damage)
    {
        foreach (GameObject g_Enemy in g_Enemies)
        {
            if (g_Enemy != null)
            {
                if (g_Enemy.GetComponentInChildren<HitPlayer>().damageClone)
                {
                    int enemyDamage = damage;

                    DecreaseHealth(healthSystem, enemyDamage);
                    g_health.transform.localScale = GetHealtBar(healthSystem);
                    g_Enemy.GetComponentInChildren<HitPlayer>().damageClone = false;
                    //Player will received point when getting hit by enemy
                    GameManager.instance.playerPoint += healthSystem.GetPointFromEnemyHit(enemyDamage);
                }
            }
        }
    }
    private void DecreaseHealth(HealthSystem healthSystem, int enemyDamage)
    {
        healthSystem.Damage(enemyDamage);
    }

    private void Die()
    {
        if (healthSystem.GetHealth() == 0)
        {
            gameObject.SetActive(false);
        }
    }
    private Vector2 GetHealtBar(HealthSystem healthSystem)
    {
        Vector2 healthBar = new Vector2(healthSystem.GetHealth(), 1);
        return healthBar;
    }
}
