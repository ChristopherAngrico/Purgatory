using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingTimer : MonoBehaviour
{
    FunctionTimer swamEnemy;
    private void Start() {
        FunctionTimer.Create(SwamEnemy, 3f);
        FunctionTimer.Create(MonyetEnemy, 5f);
    }
   
    private void SwamEnemy(){
        print("Halo");
    }
    private void MonyetEnemy(){
        print("anjing");
    }
}
