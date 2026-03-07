
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour{
    private int health = 10;
    public int coins;
    public AudioSource audioSource;
    public AudioClip damageSound;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void TakeDamage(int damage){
        health-=damage;  //отнимает здоровье
        print("Здоровье игрока:" + health); //Сообщает о здоровье игрока

        if(health > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
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


