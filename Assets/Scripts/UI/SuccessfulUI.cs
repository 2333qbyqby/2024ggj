using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessfulUI : MonoBehaviour
{
    public Image visual;

    private void Start()
    {
        this.HideUI();
    }

    public void HideUI()
    {
        this.gameObject.SetActive(false);
    }

    public void ShowUI()
    {
        this.gameObject.SetActive(true);
        //StartCoroutine(EndCR());
    }
}
