public class HealthSystem
{
    public float currentHealth;
    float maxHealth;
    public HealthSystem(int maxHealth, bool isShield)
    {
        this.maxHealth = maxHealth;
        currentHealth = isShield ? 0 : maxHealth;
    }
    public float GetHealth()
    {
        if (currentHealth <= 100)
        {
            return currentHealth / maxHealth;
        }
        else
        {
            return 1;
        }
    }

    public void Damage(int damageReceive)
    {
        currentHealth -= damageReceive;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    public int GetPointFromEnemyHit(int point)
    {
        return point;
    }

    public void SetCurrentHealth(int addHealth)
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += addHealth;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }
}
