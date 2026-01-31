using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    public AudioClip damageSound; 
    public AudioClip collectSound; 

    public void CollecCoint()
    {
        coins++;    //Увеличивает кол-во менет на 1
        audioSource.PlayOneShot(collectSound);  //Проишрывает звук
        print("Собранные монетки:"+coins);  //Сообщает о собранных монетках
    }
     
}
