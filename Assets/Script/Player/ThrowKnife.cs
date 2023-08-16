using UnityEngine;
using System.Collections;

public class ThrowKnife : MonoBehaviour
{
    [SerializeField] GameObject g_knife;
    [SerializeField] Transform positionToThrow;
    [SerializeField] float throwSpeed;
    [SerializeField] float adjustDelay;
    [HideInInspector] public float byFollowingMouseDirection;
    [HideInInspector] public bool triggerAttack;
    [HideInInspector] public bool isAttacking;
    [HideInInspector] public bool throwKnife;
    
    
    float rotationZ;
    Vector2 direction;
    bool onDelay;
    private void Update()
    {
        if (PlayerInput.getPlayerInput.attack && !onDelay)
        {
            triggerAttack = true;
            PlayerInput.getPlayerInput.attack = false;
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionToThrow.transform.position.z));
            Vector2 difference = mousePosition - transform.position;
            rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            direction = difference.normalized;
            byFollowingMouseDirection = direction.x;
        }
        else
        {
            PlayerInput.getPlayerInput.attack = false;
        }
        if (throwKnife)
        {
            throwKnife = false;
            ThrowKnifeDirection();
            //Disable player attack to avoid continous attacking
            StartCoroutine(DelayTheMouse());
        }
    }
    private IEnumerator DelayTheMouse()
    {
        onDelay = true;
        yield return new WaitForSeconds(adjustDelay);
        onDelay = false;
    }
    private void ThrowKnifeDirection()
    {
        GameObject knifeClone = Instantiate(g_knife) as GameObject;
        knifeClone.transform.position = positionToThrow.transform.position;
        knifeClone.transform.rotation = Quaternion.Euler(0, 0, rotationZ + 90);
        knifeClone.GetComponent<Rigidbody2D>().velocity = direction * throwSpeed;
    }

}
