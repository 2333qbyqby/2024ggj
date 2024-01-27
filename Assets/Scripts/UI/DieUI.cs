using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private Button RestartButton;
    [SerializeField] private Button BackButton;
    private void Start()
    {
        RestartButton.onClick.AddListener(() => { GameManager.Instance.ReStartGame(); });
        BackButton.onClick.AddListener(() => { GameManager.Instance.BackToMenu(); });
    }
    public void ShowUI()
    {
        Sprite sprite = sprites[Random.Range(0, sprites.Count)];
        this.gameObject.GetComponent<Image>().sprite = sprite;
        this.gameObject.SetActive(true);
    }
    public void HideUI()
    {
        this.gameObject.SetActive(false);
    }
}
