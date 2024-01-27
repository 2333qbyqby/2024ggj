using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using fivuvuvUtil;

public class PlayerInput : MonoSingleton<PlayerInput>
{
    private Rigidbody rb;
    private InputSystem playerInputAction;//���ڿ�ͷ����Ͳ���ȫ�ֱ�����
    public UnityEvent playerJumpStartEvent;
    public UnityEvent playerJumpEndEvent;
    override public void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody>();
        playerInputAction = new InputSystem();//��Ϊû�н��ű��󶨸��������Բ���get component
        playerInputAction.Player.Enable();
        playerInputAction.Player.Jump.started += Jump_started;//��Player��jump����ִ�к󴥷����¼���Ӻ���4
        playerInputAction.Player.Jump.canceled += Jump_canceled;
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
