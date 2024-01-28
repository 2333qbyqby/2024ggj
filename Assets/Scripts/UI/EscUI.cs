using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscUI : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button restartButton;
    [SerializeField] private Button backButton;

    private void Start()
    {
        restartButton.onClick.AddListener(() => { GameManager.Instance.ReStartGame(); });
        backButton.onClick.AddListener(() => { GameManager.Instance.BackToMenu(); });
        this.HideUI();
    }

    public void HideUI()
    {
        this.gameObject.SetActive(false);
    }

    public void ShowUI()
    {
        this.gameObject.SetActive(true);
    }
}
