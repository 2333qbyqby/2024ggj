using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
    [Header("×é¼þ")]
    public SpriteRenderer spriteRenderer;
    private void OnEnable()
    {
    }
    private void Start()
    {
        int[] ints = { 2, 5, 6, 8 };
        int r = Random.Range(0, ints.Length);
        EmojiManager.Instance.ChangeEmoji(spriteRenderer, "tree" + ints[r]);
        PlayerState.Instance.changeTreesEmoji.AddListener(ChangeTreeSprite);
        //spriteRenderer.sprite = EmojiManager.Instance.spritesDict[];
    }
    public void ChangeTreeSprite(string emojiName)
    {
        spriteRenderer.sprite = EmojiManager.Instance.spritesDict[emojiName];
    }



}
