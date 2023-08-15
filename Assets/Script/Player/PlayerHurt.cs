using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : MonoBehaviour
{
    [SerializeField] private LayerMask enemyLayer;
    GameObject[] g_minions;
    GameObject[] g_bosses1;
    GameObject[] g_bosses2;
    HealthSystem healthSystem;
    public HealthSystem shieldSystem;
    [SerializeField] GameObject g_health;
    [SerializeField] GameObject g_shield;
    [HideInInspector] public bool isDying;
    private void Start()
    {
        healthSystem = new HealthSystem(100);
        shieldSystem = new HealthSystem(GameManager.instance.assignValueToShield);
    }
    void FixedUpdate()
    {
        g_minions = GameObject.FindGameObjectsWithTag("Minion");
        GettingHitByEnemy(g_minions, 14);

        g_bosses1 = GameObject.FindGameObjectsWithTag("Boss1");
        GettingHitByEnemy(g_bosses1, 40);

        g_bosses2 = GameObject.FindGameObjectsWithTag("Boss2");
        GettingHitByEnemy(g_bosses2, 40);
        //Player Die
        Die();
    }
    private void GettingHitByEnemy(GameObject[] g_Enemies, int damage)
    {
        foreach (GameObject g_Enemy in g_Enemies)
        {
            if (g_Enemy != null)
            {
                if (g_Enemy.GetComponentInChildren<HitPlayer>().damagePlayer)
                {
                    int enemyDamage = damage;
                    DecreaseHealth(enemyDamage);
                    if (shieldSystem.currentHealth <= 0)
                        g_health.transform.localScale = GetHealtBar();
                    else
                        g_shield.transform.localScale = GetHealtBar();
                    g_Enemy.GetComponentInChildren<HitPlayer>().damagePlayer = false;
                    //Player will received point when getting hit by enemy
                    GameManager.instance.playerPoint += healthSystem.GetPointFromEnemyHit(enemyDamage);
                }
            }
        }
    }
    private void DecreaseHealth(int enemyDamage)
    {
        healthSystem.Damage(enemyDamage);
    }

    private void Die()
    {
        if (healthSystem.currentHealth == 0)
        {
            isDying = true;
            // GameManager.instance.FreezeTime();
        }
    }
    private Vector2 GetHealtBar()
    {
        Vector2 healthBar = new Vector2(healthSystem.GetHealth(), 1);
        return healthBar;
    }
}
