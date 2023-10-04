using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    InputSystem inputSystem;
    float movementSpeed = 8f;
    [HideInInspector] public bool isRunning;
    [SerializeField]ThrowKnife throwKnife;
    float allowToMove;
    float differenceXPosition;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FlippingSprite()
    {
        //Flipping sprite by following mouse direction
        if (differenceXPosition < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
    private void FixedUpdate()
    {

        allowToMove = throwKnife.isAttacking ? 0 : 1;
        rb.velocity = PlayerInput.getPlayerInput.direction * movementSpeed;

        //Checking is running
        if (PlayerInput.getPlayerInput.direction != Vector2.zero)
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
        FlippingSprite();
    }

    private void Update(){
        FollowMouseDirection();
    }

    private void FollowMouseDirection(){
        Vector2 getMousePosition = Input.mousePosition;
        //Convert to screen to world space
        Vector3 getMouseWorldPosition = Camera.main.ScreenToWorldPoint((Vector3)getMousePosition);
        differenceXPosition = getMouseWorldPosition.x - transform.position.x;
    }
}
