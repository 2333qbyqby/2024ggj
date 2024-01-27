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

    private void OnEnable()
    {
        
    }

    private void Update()
    {
        if (true)
        {
            //changeTreesEmoji?.Invoke();
        }
    }
}  
   

