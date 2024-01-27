using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fivuvuvUtil;

public class GameManager : MonoSingleton<GameManager>
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlayerDeath(GameObject player)
    {
        //TODO UI
        if (player != null)
        {
            PlayerInput.Instance.DisablePlayerInput();
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            player.GetComponent<PlayerMovement>().playerAnimator.SetJump(false);
            player.GetComponent<PlayerMovement>().playerAnimator.SetDie(true);
            
        }
        
    }
}
