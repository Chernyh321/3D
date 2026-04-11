using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        CoinsCounter coinsCounter = other.GetComponent<CoinsCounter>();
        coinsCounter. CollectCoin();
        Destroy(gameObject);
    }
}

