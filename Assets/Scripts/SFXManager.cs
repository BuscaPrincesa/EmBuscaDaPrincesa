using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

  

    public GameObject dieParticles;

    void Awake(){
        if (instance == null){
            instance = this;
        }
    }

 

        public void ShowDieParticles(GameObject obj){
        GameObject particles = Instantiate(dieParticles, obj.transform.position, Quaternion.identity);
        GameObject parent = GameObject.Find("Tape");
        particles.transform.SetParent(parent.gameObject.transform);
    }
}
