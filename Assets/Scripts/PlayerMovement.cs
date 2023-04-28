using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 控制玩家移动

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    public float speed=10f;//
    public Vector3 moveDirection;//设置移动方向

    private void Start(){
        //获取player身上的charactercontroller组件
        characterController=GetComponent<CharacterController>();
    }

    private void Update(){
        Move();
    }

    private void Move(){
        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");

        moveDirection=(transform.right*h+transform.forward*v).normalized;//设置玩家移动方向
        characterController.Move(moveDirection*speed*Time.deltaTime);
    }
}
