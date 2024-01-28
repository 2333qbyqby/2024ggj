using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFaceChange : MonoBehaviour
{
    public Sprite oldFace;
    public string targetEmojiName;
    public float changeBackTime = 3f;
    private GameObject player;
    public List<Trees> treesAround;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            player=collision.gameObject;
            oldFace = player.GetComponent<PlayerEmojiController>().spriteRenderer.sprite;
            EmojiManager.Instance.ChangeEmoji(collision.gameObject.GetComponent<PlayerEmojiController>().spriteRenderer, targetEmojiName);
            Invoke("ChangeBackEmoji", changeBackTime);
            if (treesAround != null)
            {
                foreach (Trees tree in treesAround)
                {
                    int[] a = { 1, 4, 9 };
                    tree.RandomChangeTreeEmoji(a);
                }
            }
            
        }
    }

    
    public void ChangeBackEmoji()
    {
        player.GetComponent<PlayerEmojiController>().spriteRenderer.sprite = oldFace;
        Destroy(this.gameObject);
    }

   
}
