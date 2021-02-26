using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimator : MonoBehaviour
{
    private Animator m_Animator;
    // Use this for initialization
    void Start()
    {
        m_Animator = this.GetComponent<Animator>();

        Debug.Log("Here");

        // 这里的-1能否省略.

        // m_Animator.Play("ani_piggybank_small_idel", -1, 0.25f);
        // m_Animator.Play("ani_piggybank_small_idel", -1, 0.25f);

        // m_Animator.Update();

        // m_Animator.Play("ani_piggybank_small_idel");
        // m_Animator.Update(100.0f);



    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Left");
            m_Animator.enabled = true;
            m_Animator.Play("ani_piggybank_small_idel");
        }

        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("Right");
            m_Animator.Play("ani_piggybank_small_idel",0,0);
            // m_Animator.Update(0);
            m_Animator.Update(0);
            m_Animator.enabled = false;
            // m_Animator.Update(1.5f);
        }

    }


}
