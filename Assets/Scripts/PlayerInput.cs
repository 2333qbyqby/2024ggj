using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody rb;
    private InputSystem playerInputAction;//���ڿ�ͷ����Ͳ���ȫ�ֱ�����
    public UnityEvent playerJumpStartEvent;
    public UnityEvent playerJumpEndEvent;
    private void Awake()
    {
        
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
}
