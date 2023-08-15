using TMPro;
using UnityEngine;

public class Point : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int point;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {

        text.text = "Point:" + GameManager.instance.playerPoint.ToString();

    }
}
