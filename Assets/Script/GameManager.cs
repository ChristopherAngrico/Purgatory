using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject UI_Die;
    [SerializeField] GameObject UI_gameComplete;
    [SerializeField] GameObject g_minion;
    [SerializeField] GameObject[] g_boss;
    [HideInInspector] public GameObject g_assignEnemy;
    [SerializeField] SpawnEnemy script_spawnEnemy;
    [HideInInspector] public int playerPoint = 0;
    [HideInInspector] public int upgradeKnifeDamage = 0;
    [HideInInspector] public int assignValueToShield = 0;
    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }
    private void Start()
    {
        //Make it easy game for the first
        Delay(2);
        Minion();
        //In first Minute spam the minion
        FunctionTimer.Create(SpamMinion, 60);
        FunctionTimer.Create(SpawnMinionInNormalTime, 62);//Set the spawn enemy in the normal time
        //In two minute Deploy 2 enemy boss
        FunctionTimer.Create(StopSpawning, 120);
        FunctionTimer.Create(SpawnFirstBoss, 123);
        FunctionTimer.Create(StopSpawning, 124);
        //In third until fith Deploy the last boss and then the game is end
        FunctionTimer.Create(SpawnSecondBoss, 210);
        FunctionTimer.Create(StopSpawning, 211);
    }

    public void Die()
    {
        Time.timeScale = 0;
        UI_Die.SetActive(true);
    }

    public void Finished()
    {
        Time.timeScale = 0;
        UI_gameComplete.SetActive(true);
    }
    private void Delay(float adjustDelay)
    {
        script_spawnEnemy.adjustDelay = adjustDelay;
    }
    private void Minion()
    {
        g_assignEnemy = g_minion;
    }
    private void SpamMinion()
    {
        print("Spawn");
        Delay(0.5f);
        g_assignEnemy = g_minion;
    }
    private void SpawnMinionInNormalTime()
    {
        Delay(2f);
        Minion();
    }
    private void StopSpawning()
    {
        script_spawnEnemy.StopSpawn();
    }
    private void StartSpawning()
    {
        script_spawnEnemy.StartSpawn();
    }
    private void SpawnFirstBoss()
    {
        StartSpawning();
        Delay(2f);
        g_assignEnemy = g_boss[0];
    }
    private void SpawnSecondBoss()
    {
        StartSpawning();
        Delay(2f);
        g_assignEnemy = g_boss[1];
    }
}
