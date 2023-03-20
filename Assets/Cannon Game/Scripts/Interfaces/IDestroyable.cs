using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDestroyable
{
    [SerializeField]
    private static GameObject particleEffect;

    void Destroy();
}
