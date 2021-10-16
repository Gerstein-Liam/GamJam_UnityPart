using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animation00_cube : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator _Animator;
    private bool JumpCondition = false;
    private bool RotateCondition = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        _Animator.SetBool("rotate_condition", RotateCondition);
        _Animator.SetBool("jump_condition", JumpCondition);

        JumpCondition = false;
        RotateCondition = false;
    }


    public void JumpEvent(InputAction.CallbackContext _InputAction) {

        Debug.Log("JumpEvent");
        JumpCondition = true;

    }

    public void RotateEvent(InputAction.CallbackContext _InputAction)
    {

        Debug.Log("RotateEvent");
        RotateCondition = true;

    }
}
