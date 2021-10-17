using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class animation_blenderfighter00 : MonoBehaviour
{
    public Animator _Animator;
    private bool PunchCondition = false;
    private bool KickCondition = false;
    string m_ClipName;
    AnimatorClipInfo[] m_CurrentClipInfo;

    float m_CurrentClipLength;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        m_CurrentClipInfo = this._Animator.GetCurrentAnimatorClipInfo(0);
        //Access the current length of the clip
        m_CurrentClipLength = m_CurrentClipInfo[0].clip.length;
        //Access the Animation clip name
        m_ClipName = m_CurrentClipInfo[0].clip.name;

        if (m_CurrentClipInfo[0].clip.name != null) {


            _Animator.SetBool("punch_condition", PunchCondition);
            _Animator.SetBool("kick_condition", KickCondition);

            PunchCondition = false;
            KickCondition = false;
        }
     
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
    void OnGUI()
    {
        //Output the current Animation name and length to the screen
        GUI.Label(new Rect(0, 0, 200, 20), "Clip Name : " + m_ClipName);
        GUI.Label(new Rect(0, 30, 200, 20), "Clip Length : " + m_CurrentClipLength);


    }
}
