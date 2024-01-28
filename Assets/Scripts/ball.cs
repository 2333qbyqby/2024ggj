using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer ==7)
        {
            GameManager.Instance.PlayerDeath(collision.gameObject);
            Debug.Log("«Ú‘“µΩ¡À»À");
            Destroy(gameObject);
        }
        
    }
    private void OnEnable()
    {
        Invoke("DestoryItself", 3f);
    }
    public void DestoryItself()
    {
        Destroy(gameObject);
    }
}
