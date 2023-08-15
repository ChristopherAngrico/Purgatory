using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject g_UI_Menu;
    public void Pause(){
        g_UI_Menu.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}
