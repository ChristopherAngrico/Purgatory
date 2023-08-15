using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_GameComplete : MonoBehaviour
{
    [SerializeField] GameObject g_UI_image;
    [SerializeField] GameObject g_quit_button;
    float time;

    private void Update()
    {
        time += Time.unscaledDeltaTime;
        if (time > 2)
        {
            g_UI_image.SetActive(true);
            g_quit_button.SetActive(true);
        }


    }
    public void ChangeScene()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
    }
}
