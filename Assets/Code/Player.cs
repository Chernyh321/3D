using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public AudioSource audioSource;
    public AudioClip damageSound; 
    public AudioClip collectSound; 

    public void TakeDamage(int damage){
        health-=damage  //отнимает здоровье
        print("Здоровье игрока:" + health); //Сообщает о здоровье игрока


    }

    public void CollecCoint()
    {
        coins++;    //Увеличивает кол-во менет на 1
        audioSource.PlayOneShot(collectSound);  //Проишрывает звук
        print("Собранные монетки:"+coins);  //Сообщает о собранных монетках
    }
     
}
