using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manholeCover : MonoBehaviour
{
    public Animator animator;
    public float force=3f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer==7) 
        {
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
            collision.gameObject.GetComponent<Rigidbody2D>().velocity=Vector2.zero;
            playerMovement.RefreshGravityScale();
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(force*this.transform.up, ForceMode2D.Impulse);
            animator.SetTrigger("IsTrigger");

        }

    }

    public IEnumerator StartShootCR(Collider2D collision)
    {
        yield return new WaitForSeconds(0.5f);
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force), ForceMode2D.Impulse);
    }
    
    
}
