using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    Camera _camera;
    GameObject g_target;
    Vector3 followTarget;
    [SerializeField]private Vector3 adjustPosition;
    private void Awake()
    {
        _camera = GetComponent<Camera>();
       g_target = GameObject.FindWithTag("Player");
    }
    private void Update()
    {
        if (this.gameObject.name == "Main Camera")
            followTarget = new Vector3(g_target.transform.position.x, g_target.transform.position.y, -10);
        else
            followTarget = g_target.transform.position;
        transform.position = followTarget + adjustPosition;
    }
}
