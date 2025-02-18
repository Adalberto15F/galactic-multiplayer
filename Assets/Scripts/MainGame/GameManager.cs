using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class GameManager : NetworkBehaviour
{
    [SerializeField] private Camera cam;
    
    public override void Spawned()
    {
        cam.gameObject.SetActive(false);
    }
}
