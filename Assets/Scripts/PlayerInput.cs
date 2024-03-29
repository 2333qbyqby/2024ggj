using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using fivuvuvUtil;
using Unity.IO.LowLevel.Unsafe;

public class PlayerInput : MonoSingleton<PlayerInput>
{
    private Rigidbody rb;
    private InputSystem playerInputAction;//不在开头定义就不是全局变量了
    public UnityEvent playerJumpStartEvent;
    public UnityEvent playerJumpEndEvent;
    public UnityEvent playerInteractEvent;
    public UnityEvent playerSaveEvent;
    public UnityEvent playerLoadEvent;
    public UnityEvent playerEscEvent;
    override public void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody>();
        playerInputAction = new InputSystem();//因为没有将脚本绑定给物体所以不用get component
        playerInputAction.Player.Enable();
        playerInputAction.UI.Enable();
        playerInputAction.Player.Jump.started += Jump_started;//给Player的jump动作执行后触发的事件添加函数4
        playerInputAction.Player.Jump.canceled += Jump_canceled;
        playerInputAction.Player.Interact.performed += Interact_performed;
        playerInputAction.Player.Save.performed += Save_performed;
        playerInputAction.Player.Load.performed += Load_performed;
        playerInputAction.UI.Esc.performed += Esc_performed;
    }

    private void Esc_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        playerEscEvent?.Invoke();
    }

    private void Load_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        playerLoadEvent?.Invoke();
    }

    private void Save_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        playerSaveEvent?.Invoke();
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        playerInteractEvent?.Invoke();
    }

    private void Jump_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        playerJumpEndEvent?.Invoke();
    }

    private void Jump_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        playerJumpStartEvent?.Invoke();
    }


    public Vector2 GetPlayerMoveVector()
    {
        return playerInputAction.Player.Move.ReadValue<Vector2>();
    }


    public void EnablePlayerInput()
    {
        playerInputAction.Player.Enable();
    }
    public void DisablePlayerInput()
    {
        playerInputAction.Player.Disable();
    }


    
}
