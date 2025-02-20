using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] private CinemachineImpulseSource impulseSourse;

    public void ShakeCamera(Vector3 shakeAmount)
    {
        impulseSourse.GenerateImpulse(shakeAmount);
    }
}


