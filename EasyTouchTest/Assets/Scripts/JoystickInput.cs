using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickInput : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float base_speed = 20.0f;
    private float _x_speed = 0f;
    private float _z_speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        ETCJoystick js = GameObject.Find("New Joystick").GetComponent<ETCJoystick>();
        js.onMove.AddListener(OnJoystickMove);
        js.onMoveSpeed.AddListener(OnJoystickMoveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnJoystickMove(Vector2 pos)
    {
        // Debug.Log("OnJoystickMove pos.x=" + pos.x + " pos.y=" + pos.y);
        float deltaX = pos.x * _x_speed;
        float deltaZ = pos.y * _z_speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ) * base_speed;
        movement *= Time.deltaTime;

        movement += transform.position;
        _rigidbody.MovePosition(movement);
    }

    public void OnJoystickMoveSpeed(Vector2 pos)
    {
        // Debug.Log("OnJoystickMoveSpeed pos.x=" + pos.x + " pos.y=" + pos.y);
        _x_speed = Math.Abs(pos.x);
        _z_speed = Math.Abs(pos.y);
    }
}
