using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFoller : MonoBehaviour
{
   public GameObject Camera;
    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {
        transform.LookAt(Camera.transform);
    }
}
