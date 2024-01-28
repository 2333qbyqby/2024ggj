using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fivuvuvUtil;
using UnityEngine.SceneManagement;
using FivuvuvUtil;

public class GameManager : MonoSingleton<GameManager>
{
    [Header("玩家道具数量")]
    public int appleCount;

    public DieUI dieUI;


    public void ReStartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
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
            dieUI.ShowUI();
            AudioManagerForGamejam.Instance.PlaySFX("death"+Random.Range(1,4));
            Invoke("ReStartGame", 0.5f);
            
        }
        
    }

    
}
