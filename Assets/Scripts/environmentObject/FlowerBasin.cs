using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBasin : MonoBehaviour
{
    public float gravity;
    public float fallTime=3f;
    [SerializeField] private bool ifAdded;
    public Sprite brokenFlowerBasin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            StartCoroutine(FlowerBasinWait());
        }
    }

    public IEnumerator FlowerBasinWait()
    {
        yield return new WaitForSeconds(fallTime);
        FlowerBasinFall();
    }

    public void FlowerBasinFall()
    {
        if (!ifAdded)
        {

        this.gameObject.AddComponent<Rigidbody2D>().gravityScale=gravity;
            ifAdded = true;
            Invoke("DestoryGameObject", 5f);
        }
        
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            PlayerEmojiController playerEmojiController = collision.gameObject.GetComponent<PlayerEmojiController>();
            playerEmojiController.emojiType = EmojiType.horribleflower;
            Debug.Log("±ä»¨");
            EmojiManager.Instance.ChangeEmoji(collision.gameObject.GetComponent<PlayerEmojiController>().spriteRenderer,EmojiType.horribleflower.ToString());
            this.gameObject.GetComponentInChildren<SpriteRenderer>().sprite = brokenFlowerBasin;
            Invoke("DestoryGameObject", 1f);

        }
    }

    public void DestoryGameObject()
    {
        Destroy(this.gameObject);
    }
}
