using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private Material _material;
    private Vector2 playerDirection,followPlayer;
    private float playerSpeed = 0.3f;
    private void Start()
    {
        _material = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        playerDirection = PlayerInput.getPlayerInput.direction;
        followPlayer += playerDirection * playerSpeed * Time.deltaTime;
        _material.SetTextureOffset("_MainTex", followPlayer);//The material goes reverse so assign negative to make it normal
    }
}
