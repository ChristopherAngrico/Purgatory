
public class HealthSystem
{
    public float currentHealth;
    float maxHealth;
    public HealthSystem(int maxHealth)
    {
        this.maxHealth = maxHealth;
        currentHealth = maxHealth;
    }
    private void Heal(int healAmount){
        currentHealth += healAmount;
        if(currentHealth >= 100){
            currentHealth = 100;
        }
    }
    public float GetHealth()
    {
        return currentHealth / maxHealth;
    }

    public void Damage(int damageReceive)
    {
        currentHealth -= damageReceive;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    public int GetPointFromEnemyHit(int point){
        return point;
    }
}
