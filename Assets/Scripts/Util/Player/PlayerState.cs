using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fivuvuvUtil;
using UnityEngine.Events;

public class PlayerState : MonoSingleton<PlayerState>
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public UnityEvent<string> changeTreesEmoji;
    [Header("Íæ¼Ò×´Ì¬")]
    public bool isChangeToFlower;
    public bool ifHit;
    public bool ifjumpSeveralTimes;
    private void OnEnable()
    {
        
    }

    

    public void ChangeAllTreeEmoji() 
    {
        changeTreesEmoji?.Invoke("tree1");
    }

}  
   

