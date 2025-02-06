using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class GlobalManagers : MonoBehaviour
{
    public static GlobalManagers Instance { get; private set; }

    [SerializeField] private GameObject parentObjs;
    [field: SerializeField] public NetworkRunnerController NetworkRunnerController { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(parentObjs);
        }
        
    }
}
