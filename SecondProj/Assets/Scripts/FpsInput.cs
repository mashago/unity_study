using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FpsInput : MonoBehaviour
{
	public float speed = 6.0f;
	public float gravity = -9.8f;
	// include object collision
	private CharacterController _charController;
    // Start is called before the first frame update
    void Start()
    {
		// get component from GameObject
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);

		// limit vector speed
		movement = Vector3.ClampMagnitude(movement, speed);
		movement.y = gravity;
		movement *= Time.deltaTime;

		// local coordinate change to global coordinate
		movement = transform.TransformDirection(movement);
		_charController.Move(movement);
    }
}
