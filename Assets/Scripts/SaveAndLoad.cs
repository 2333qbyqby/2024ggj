using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fivuvuvUtil;

public class SaveAndLoad : MonoSingleton<SaveAndLoad>
{
    public Transform savePoint;

    public GameObject player;

    private void Start()
    {
        PlayerInput.Instance.playerSaveEvent.AddListener(Save);
        PlayerInput.Instance.playerLoadEvent.AddListener(Load);
        DontDestroyOnLoad(this);
    }
    
    public void Save()
    { 
        PlayerPrefs.SetFloat("PlayerPositionX",player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerPositionY", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerPositionZ", player.transform.position.z);
        PlayerPrefs.Save();
        Debug.Log("save≥…π¶");
    }
    public void Load()
    {
        if(PlayerPrefs.HasKey("PlayerPositionX")&& PlayerPrefs.HasKey("PlayerPositionY")&& PlayerPrefs.HasKey("PlayerPositionZ"))
        {
            float x = PlayerPrefs.GetFloat("PlayerPositionX");
            float y = PlayerPrefs.GetFloat("PlayerPositionY");
            float z = PlayerPrefs.GetFloat("PlayerPositionZ");
            player.transform.position = new Vector3(x,y,z);

        }
        else
        {
            Debug.Log("load ß∞‹");
        }
    }
}
