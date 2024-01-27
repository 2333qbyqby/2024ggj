using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("主界面UI按钮")]
    public Button startButton;
    public Button quitButton;
    public Button staffButton;//制作人员按钮
    private void Start()
    {
        startButton.onClick.AddListener(() => { SceneManager.LoadScene(1); });
        quitButton.onClick.AddListener(() => { Application.Quit(); });
    }

    
}
