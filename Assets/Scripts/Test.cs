using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Transform emojiSpriteTransform = collision.transform.Find("Emoji");

        EmojiManager.Instance.ChangeEmoji(emojiSpriteTransform.GetComponent<SpriteRenderer>(), "test");
    }
}
