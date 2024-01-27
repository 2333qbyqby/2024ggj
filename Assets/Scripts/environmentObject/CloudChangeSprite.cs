using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudChangeSprite : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer == 7)
        {
            ChangeFace("cloud7");
            StartCoroutine(ReturnIdleStateCR());
        }
    }

    public IEnumerator ReturnIdleStateCR()
    {
        yield return new WaitForSeconds(3);
        ChangeFace("cloud1");
        
    }
    public void ChangeFace(string name)
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = EmojiManager.Instance.spritesDict[name];
    }
}
