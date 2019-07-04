using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;

    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f);

    [SerializeField]
    private Transform Tape = null;

    public UIComponents uiComponents;

    void Awake(){
        Assert.IsNotNull(Tape);
        if (instance == null){
            instance = this;
        }
    }


    
    public void SetTapeSpeed(float value) {
        TapeSpeed = new Vector3(value, TapeSpeed.y, TapeSpeed.z);
    }

    public void ShowLevelCompletePanel() {
        uiComponents.levelCompletePanel.Panel.SetActive(true);
        
    }

    public void ShowGameOverPanel()
    {
        uiComponents.gameOverPanel.Panel.SetActive(true);
        
    }
}
