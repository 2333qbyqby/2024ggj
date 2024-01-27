using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    

    public GameObject Ball;

    public float speed;

    

    public float timer=3f;
    public float changeTimer;
    public float shootTimer=1f;
    public float shootChangeTimer;
    public int direction = 1;
    private void Start()
    {
        
        changeTimer = timer;
        shootChangeTimer = shootTimer;

    }
    private void Update()
    {
        Run();
        Shoot();
    }
    

    public void Run()
    {
        
        changeTimer -= Time.deltaTime;
        transform.position += Vector3.right * Time.deltaTime * speed * direction;
        if (changeTimer < 0 )
        {
            
            changeTimer = timer;
            direction *= -1;
        }
    }
    public void Shoot()
    {
        shootChangeTimer -= Time.deltaTime;
        if (shootChangeTimer < 0)
        {
            shootChangeTimer = shootTimer;
            GameObject ball = Instantiate(Ball, transform.position, Quaternion.identity);
            ball.AddComponent<Rigidbody2D>().gravityScale = 0.6f;
        }
        

    }
}
