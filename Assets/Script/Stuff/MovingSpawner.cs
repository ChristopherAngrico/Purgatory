using UnityEngine;

public class MovingSpawner : MonoBehaviour
{
    public GameObject[] g_idx;
    private int direction;
    public bool horizontalMove, verticalMove;
    [SerializeField] private float moveSpeed;
    private void Start()
    {
        if (Random.Range(0,5) < 2)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
    }
    private void FixedUpdate()
    {
        if(verticalMove)
            MoveVertical();
        if(horizontalMove)
            MoveHorizontal();
    }

    //To Do: Move spawner from one to another
    private void MoveVertical()
    {
        if (Mathf.Abs(transform.localPosition.y - g_idx[0].transform.localPosition.y) < 0.1)
            direction = -1;
        else if(Mathf.Abs(transform.localPosition.y - g_idx[1].transform.localPosition.y) < 0.1)
             direction = 1;
        transform.localPosition += direction * moveSpeed * Vector3.up * Time.deltaTime;
    }
    private void MoveHorizontal(){
        if (Mathf.Abs(transform.localPosition.x - g_idx[0].transform.localPosition.x) < 0.1)
            direction = 1;
        else if(Mathf.Abs(transform.localPosition.x - g_idx[1].transform.localPosition.x) < 0.1)
             direction = -1;
        transform.localPosition += direction * moveSpeed * Vector3.right * Time.deltaTime;
    }
}
