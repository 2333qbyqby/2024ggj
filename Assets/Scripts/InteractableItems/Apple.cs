using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public bool ifGeted;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            if (ifGeted==false)
            {
            PlayerInput.Instance.playerInteractEvent.AddListener(GetApple);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {            
                PlayerInput.Instance.playerInteractEvent.RemoveListener(GetApple);      
        }
    }

    public void GetApple()
    {
        GameManager.Instance.appleCount++;
        ifGeted = true;
        Destroy(this.gameObject);
    }
}
