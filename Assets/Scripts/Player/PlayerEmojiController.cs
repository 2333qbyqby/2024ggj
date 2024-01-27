using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerEmojiController : MonoBehaviour
{

    [Header("Ä¬ÈÏemoji")]
    public EmojiType emojiType;
    [Header("emoji")]
    public SpriteRenderer spriteRenderer;

    [Header("StateCount")]
    public int count;
    private void Start()
    {
        emojiType= EmojiType.player1;
    }
    private void Update()
    {


    }
    public void JumpChangeEmoji(Vector2 velocity)
    {
        if (velocity.y >= 20)
        {
            EmojiManager.Instance.ChangeEmoji(spriteRenderer, EmojiType.player8.ToString());
        }
        else if (velocity.y < 20 && velocity.y >= 10)
        {
            EmojiManager.Instance.ChangeEmoji(spriteRenderer, EmojiType.player3.ToString());
        }
        else if (velocity.y < 10 && velocity.y >= 5)
        {
            EmojiManager.Instance.ChangeEmoji(spriteRenderer, EmojiType.player7.ToString());
        }
    }

    public IEnumerator ResetEmoji()
    {
        yield return new WaitForSeconds(0.5f);
        EmojiManager.Instance.ChangeEmoji(spriteRenderer,emojiType.ToString());
    }
}