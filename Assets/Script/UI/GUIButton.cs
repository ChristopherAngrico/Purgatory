using UnityEngine.SceneManagement;
using UnityEngine;

public class GUIButton : MonoBehaviour
{
    public GameObject g_PauseButton;
    public void Resume(){
        Time.timeScale = 1;
        gameObject.SetActive(false);
        g_PauseButton.SetActive(true);
    }

    public void Restart(){
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        GameManager.instance.playerPoint = 0;
    }

    public void Quit(){
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
        GameManager.instance.playerPoint = 0;
    }

    public void Canceled(){
        gameObject.SetActive(false);
        Time.timeScale = 1;
        g_PauseButton.SetActive(true);
    }
}
