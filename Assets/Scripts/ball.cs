using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer ==7)
        {
            Debug.Log("«Ú‘“µΩ¡À»À");
            Destroy(gameObject);
        }
    }
}
