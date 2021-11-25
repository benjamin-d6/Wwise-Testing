using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    Animator m_Animator;
    public ThirdPersonController TMovement;
    [Header("Wwise Events")]
    public AK.Wwise.Event myFootstep;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();    
    }


    void footstepPlay(float targetWalkSpeed)
    {
        
        float actualSpeed = TMovement._speed ;
        if (GetMovementState(targetWalkSpeed) == GetMovementState(actualSpeed))
        {
            myFootstep.Post(gameObject);
        }
    }
    private int GetMovementState(float speed)
    {
        if (speed< .5f)
        {
            return 0;
        }
        if (speed < 3f)
        {
            return 1;
        }
        return 2;

    }
}
