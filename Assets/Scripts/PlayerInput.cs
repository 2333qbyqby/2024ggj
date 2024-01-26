using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody rb;
    private InputSystem playerInputAction;//不在开头定义就不是全局变量了
    public UnityEvent playerJumpStartEvent;
    public UnityEvent playerJumpEndEvent;
    private void Awake()
    {
        
        rb = GetComponent<Rigidbody>();
        playerInputAction = new InputSystem();//因为没有将脚本绑定给物体所以不用get component
        playerInputAction.Player.Enable();
        playerInputAction.Player.Jump.started += Jump_started;//给Player的jump动作执行后触发的事件添加函数4
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
