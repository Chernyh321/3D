using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapoline : MonoBehaviour
{   public float jumpStrength=3.5f;
    void OnTriggerEnter(Collider other){
        other.GetComponent<Jump>().jumpStrength*=jumpStrength;
    }
    void OnTriggerExit(Collider other){
        other.GetComponent<Jump>().jumpStrength/=jumpStrength;
    }

}
