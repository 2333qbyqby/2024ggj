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
    public GameObject CG;
    public Sprite sprite1;
    public Sprite sprite2;

    private void Start()
    {
        CG.SetActive(false);
        startButton.onClick.AddListener(() => {


            StartCoroutine(PlayPPT());
            
        });
        quitButton.onClick.AddListener(() => { Application.Quit(); });
    }

    public IEnumerator PlayPPT()
    {
        CG.SetActive(true);
        yield return null;
        CG.GetComponent<Image>().sprite = sprite1;
        yield return new WaitForSeconds(2);
        CG.GetComponent<Image>().sprite = sprite2;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
