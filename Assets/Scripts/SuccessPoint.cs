using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==7)
        {
            StartCoroutine(GameManager.Instance.EndGame());
        }
    }
}
