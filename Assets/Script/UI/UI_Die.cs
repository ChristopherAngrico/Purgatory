using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class UI_Die : MonoBehaviour
{
    [SerializeField] GameObject g_UI_image;
    [SerializeField] GameObject g_restart_button;
    float time;
    private void Update()
    {
        time += Time.unscaledDeltaTime;
        if (time > 2)
        {
            g_UI_image.SetActive(true);
            g_restart_button.SetActive(true);
        }
    }
    public void ChangeScene()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        GameManager.instance.playerPoint = 0;
    }
}
