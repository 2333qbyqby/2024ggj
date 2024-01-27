using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathArea : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Debug.Log("death");
            GameManager.Instance.PlayerDeath(collision.gameObject);
        }
    }
}
