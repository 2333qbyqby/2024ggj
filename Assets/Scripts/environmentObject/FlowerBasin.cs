using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBasin : MonoBehaviour
{
    public float gravity;
    public float fallTime=3f;
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
        this.gameObject.AddComponent<Rigidbody2D>().gravityScale=gravity;
        
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            Debug.Log("±ä»¨");
            EmojiManager.Instance.ChangeEmoji(collision.gameObject.GetComponent<PlayerEmojiController>().spriteRenderer,EmojiType.horribleflower.ToString());

            Destroy(this.gameObject);
        }
    }
}
