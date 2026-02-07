using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    private int health = 10;


    public void TakeDamage(int damage){
        health-=damage;  //отнимает здоровье
        print("Здоровье игрока:" + health); //Сообщает о здоровье игрока
    }
}