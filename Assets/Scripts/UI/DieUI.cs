using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<Sprite> sprites;
    private void Start()
    {
        this.HideUI();
    }
    public void ShowUI()
    {
        Sprite sprite = sprites[Random.Range(0, sprites.Count)];
        this.gameObject.GetComponentInChildren<Image>().sprite = sprite;
        this.gameObject.SetActive(true);

    }
    public void HideUI()
    {
        this.gameObject.SetActive(false);
    }
}
