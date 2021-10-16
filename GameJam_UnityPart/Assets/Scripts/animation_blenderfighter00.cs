using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class animation_blenderfighter00 : MonoBehaviour
{
    public Animator _Animator;
    private bool PunchCondition = false;
    private bool KickCondition = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Animator.SetBool("punch_condition", PunchCondition);
        _Animator.SetBool("kick_condition", KickCondition);

        PunchCondition = false;
        KickCondition = false;
    }


    public void PunchEvent(InputAction.CallbackContext _InputAction)
    {

        Debug.Log("PunchCondition");
        PunchCondition = true;

    }

    public void KickEvent(InputAction.CallbackContext _InputAction)
    {

        Debug.Log("RotateEvent");
        KickCondition = true;

    }
}
