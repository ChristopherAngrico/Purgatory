using Player;
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
    [SerializeField] GameObject g_phase1, g_phase2, g_phase3;
    [HideInInspector] public bool isDying;
    float lastValueShield = 0;
    private void Start()
    {
        int healthMax = 100;
        healthSystem = new HealthSystem(healthMax, false);
        shieldSystem = new HealthSystem(healthMax, true);
    }
    void FixedUpdate()
    {
        DamageReceivedByEnemy();
        //Player Die
        Die();
    }
    private void Update()
    {
        print(shieldSystem.GetHealth());
        //Update the shield every shield that has been added
        ShieldAdded();
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
                if (g_Enemy.GetComponentInChildren<HitPlayer>().damagePlayer)
                {
                    int enemyDamage = damage;
                    if (shieldSystem.GetHealth() <= 0)
                    {
                        DecreaseHealth(healthSystem, enemyDamage);
                        g_health.transform.localScale = GetHealtBar(healthSystem);
                    }
                    else
                    {
                        DecreaseHealth(shieldSystem, enemyDamage);
                        g_shield.transform.localScale = GetHealtBar(shieldSystem);
                        UpdateTheUpgradeShield();
                        lastValueShield = shieldSystem.GetHealth();
                    }
                    g_Enemy.GetComponentInChildren<HitPlayer>().damagePlayer = false;
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
    private void ShieldAdded()
    {
        if (shieldSystem.GetHealth() > lastValueShield)
        {
            g_shield.transform.localScale = GetHealtBar(shieldSystem);
            lastValueShield = shieldSystem.GetHealth();
        }
    }
    private void UpdateTheUpgradeShield()
    {
        float shieldPhase2 = 0.68f, shieldPhase3 = 1;
        if (shieldSystem.GetHealth() < shieldPhase3)
        {
            g_phase3.SetActive(false);
            g_phase2.SetActive(true);
        }
        if (shieldSystem.GetHealth() < shieldPhase2)
        {
            g_phase2.SetActive(false);
            g_phase1.SetActive(true);
        }
        if (shieldSystem.GetHealth() == 0)
        {
            g_phase1.SetActive(false);
        }
    }
    private void Die()
    {
        if (healthSystem.GetHealth() == 0)
        {
            GetComponent<Animated>().Die();
            GameManager.instance.Die();
        }
    }
    private Vector2 GetHealtBar(HealthSystem healthSystem)
    {
        Vector2 healthBar = new Vector2(healthSystem.GetHealth(), 1);
        return healthBar;
    }

}
