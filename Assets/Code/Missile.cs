using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Missile : MonoBehaviour{

    public float speed = 10f;
    void Start()
    {
        Destroy(gameObject, 3);
    }


    void Update()
    {
        
        transform.position += 
        transform.forward *
        speed * Time.deltaTime;

    }   

        void OnTriggerEnter(Collider other)
        {
        Enemy enemy = other.GetComponent<Enemy>();
        
        }    


}

