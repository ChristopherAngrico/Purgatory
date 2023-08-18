using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotateHealth : MonoBehaviour
{
    [SerializeField]GameObject player;
    private void Update(){
        if(player.transform.rotation == Quaternion.Euler(0,180,0)){
            transform.rotation = Quaternion.Euler(0,180,0);
        }else{
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}
