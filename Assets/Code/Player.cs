
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour{
    private int health = 10;
    public int coins;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void TakeDamage(int damage){
        health-=damage;  //отнимает здоровье
        print("Здоровье игрока:" + health); //Сообщает о здоровье игрока
    }

void Update(){
    if (Input.GetMouseButtonDown(0)){
      Instantiate(fireballPrefab, 
      attackPoint.
      position, attackPoint.
      rotation);
      }
}
public void CollectCoins(){
    coins+=1;
}
}
