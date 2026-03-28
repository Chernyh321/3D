using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public int health = 10;
    public int maxHealth = 10;
    public GameObject FireballPrefab;
    public Transform attackPoint;
    public int coins;
        public void TakeDamage(int damage){
        health-=damage;  //отнимает здоровье
        print("Здоровье игрока:" + health); //Сообщает о здоровье игрока
    }

void Update(){
    if (Input.GetMouseButtonDown(0)){
      Instantiate(FireballPrefab, 
      attackPoint.
      position, attackPoint.
      rotation);
      }
}
}