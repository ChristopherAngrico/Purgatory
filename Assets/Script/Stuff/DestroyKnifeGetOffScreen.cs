using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKnifeGetOffScreen : MonoBehaviour
{
    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
