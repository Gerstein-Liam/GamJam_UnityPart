using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputSystem_CubeAction : MonoBehaviour
{
    [SerializeField]
    float RotationSpeed = 50.0f;


    private float UserI_MoveHorizontal = 0.0f;
    private float UserI_MoveVertical = 0.0f;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x+(UserI_MoveVertical * RotationSpeed * Time.deltaTime), transform.rotation.eulerAngles.y + (UserI_MoveHorizontal*RotationSpeed * Time.deltaTime), transform.rotation.eulerAngles.z );
    }

    public void OnMoveEvent_GetMoveValue(InputAction.CallbackContext context)
    {
        // Debug.Log($"Move Event {context.ReadValueAsButton()}");
        Debug.Log($"Move Event: Vector2 -> X {context.ReadValue<Vector2>().x} Y {context.ReadValue<Vector2>().y}");
        UserI_MoveHorizontal = context.ReadValue<Vector2>().x;
        UserI_MoveVertical = context.ReadValue<Vector2>().y;
 
    }
}
