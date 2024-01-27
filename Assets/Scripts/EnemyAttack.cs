using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform left;
    public Transform right;

    public GameObject Ball;

    public float speed;

    public Rigidbody2D rb;

    public float timer=3f;
    public float changeTimer;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        changeTimer = timer;

    }
    private void Update()
    {
        Run();
    }
    

    public void Run()
    {
        if(rb.position.x < left.position.x)
        {
            rb.velocity = new Vector2(speed*Time.deltaTime, 0);
        }
        else if(rb.position.x > right.position.x)
        {
            rb.velocity = new Vector2(-speed*Time.deltaTime, 0);
        }   
    }
    public void Shoot()
    {

    }
}
