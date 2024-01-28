using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessfulUI : MonoBehaviour
{
    public Sprite FinishCG;
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
        StartCoroutine(EndCR());
    }

    public IEnumerator EndCR()
    {
        yield return new WaitForSeconds(1.0f);
        visual.sprite = FinishCG;
        yield return new WaitForSeconds(3.0f);
    }
}
