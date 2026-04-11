using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{   public GameObject FireballPrefab;
    public Transform attackPoint;

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            Instantiate(FireballPrefab, 
            attackPoint.
            position, attackPoint.
            rotation);
            }
}

  
}
