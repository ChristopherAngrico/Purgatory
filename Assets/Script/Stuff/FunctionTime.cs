using System;
using UnityEngine;

public class FunctionTimer
{
    public static FunctionTimer Create(Action action, float timer)
    {
        GameObject gameObject = new GameObject("FunctionTimer", typeof(MonoBehaviourHook));

        FunctionTimer functionTimer = new FunctionTimer(action, timer, gameObject);

        gameObject.GetComponent<MonoBehaviourHook>().onUpdate = functionTimer.Update;


        return functionTimer;
    }
    private class MonoBehaviourHook : MonoBehaviour{
        public Action onUpdate;
        private void Update() {
            if(onUpdate != null) onUpdate();
        }
    }

    private Action action;
    private float timer;
    private GameObject g_object;
    private bool isDestroyed;
    public FunctionTimer(Action action, float timer, GameObject g_object)
    {
        this.action = action;
        this.timer = timer;
        this.g_object = g_object;
        isDestroyed = false;
    }

    public void Update()
    {
        if (!isDestroyed)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                // Trigger the action
                action();
                DestroySelf();
            }
        }
    }

    private void DestroySelf()
    {
        Console.WriteLine("Destroy");
        isDestroyed = true;
        UnityEngine.Object.Destroy(g_object);
    }
}
