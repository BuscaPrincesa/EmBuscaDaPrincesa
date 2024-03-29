﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other){
     

        if(other.gameObject.CompareTag("Gift")){
            StopMusicAndTape();
            AudioManager.instance.PlaySoundLevelComplete(gameObject);
            Destroy(gameObject);
            LevelManager.instance.ShowLevelCompletePanel();
            
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Enemies")){
            KillPlayer();

        }

        else if (other.gameObject.layer == LayerMask.NameToLayer("Forbidden")){
            KillPlayer();

        }
    }
    
    void StopMusicAndTape() {
        Camera.main.GetComponentInChildren<AudioSource>().mute = true;
        CameraFollow script = Camera.main.GetComponent<CameraFollow>();
        script.SetSpeed(0f);       
    }

    void KillPlayer() {
        StopMusicAndTape();
        AudioManager.instance.PlaySoundFail(gameObject);
        SFXManager.instance.ShowDieParticles(gameObject);
        Destroy(gameObject);
        LevelManager.instance.ShowGameOverPanel();
    }
}
