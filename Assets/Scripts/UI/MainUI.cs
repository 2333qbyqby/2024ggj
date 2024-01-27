using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("������UI��ť")]
    public Button startButton;
    public Button quitButton;
    public Button staffButton;//������Ա��ť
    private void Start()
    {
        startButton.onClick.AddListener(() => { SceneManager.LoadScene(1); });
        quitButton.onClick.AddListener(() => { Application.Quit(); });
    }

    
}
