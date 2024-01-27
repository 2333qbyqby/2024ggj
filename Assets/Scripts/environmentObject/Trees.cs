using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
    [Header("×é¼þ")]
    public SpriteRenderer spriteRenderer;
    private void OnEnable()
    {
        //PlayerState.Instance.changeTreesEmoji.AddListener(ChangeTreeSprite);
    }
    private void Start()
    {
        int[] ints = { 2, 5, 6, 8 };
        int r = Random.Range(0, ints.Length);
        Debug.Log("tree" + ints[r]);
        EmojiManager.Instance.ChangeEmoji(spriteRenderer, "tree" + ints[r]);
        //spriteRenderer.sprite = EmojiManager.Instance.spritesDict[];
    }
    public void ChangeTreeSprite(string emojiName)
    {
        spriteRenderer.sprite = EmojiManager.Instance.spritesDict[emojiName];
    }



}
