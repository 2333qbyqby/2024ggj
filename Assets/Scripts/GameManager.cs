using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fivuvuvUtil;
using UnityEngine.SceneManagement;
using FivuvuvUtil;
using Cinemachine;

public class GameManager : MonoSingleton<GameManager>
{
    [Header("玩家道具数量")]
    public int appleCount;

    public DieUI dieUI;
    public SuccessfulUI successfulUI;
    public EscUI escUI;


    public bool ifEscUI;
    [Header("组件")]
    public Transform virtualCamera;
    public Transform player;

    private void Start()
    {
        StartCoroutine(StartCameraFocus());
    }
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

    public void OpenEscUI()
    {
        if(!ifEscUI)
        {
            StopGame();
            escUI.ShowUI();
            ifEscUI = true;
        }
        else
        {
            ContinueGame();
            escUI.HideUI();
            ifEscUI =false;
        }
    }

    
    public IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        successfulUI.ShowUI();
        yield return new WaitForSeconds(3);
        BackToMenu();
    }

    public void StopGame()
    {
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    public IEnumerator StartCameraFocus()
    {
        yield return new WaitForSeconds(1);
        virtualCamera.gameObject.GetComponent<CinemachineVirtualCamera>().Follow = player.transform;
    }
}
