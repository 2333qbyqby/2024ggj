using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEmojiController : MonoBehaviour
{
    private PlayerMovement ownMovement;

    
    [Header("emoji")]
    public SpriteRenderer spriteRenderer;

    [Header("StateCount")]
    public int count;
    private void Start()
    {
        ownMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        if (ownMovement.IsJumping)
        {

            EmojiManager.Instance.ChangeEmoji(spriteRenderer, EmojiType.player8.ToString());
        }
    }

}
