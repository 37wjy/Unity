using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class doshake : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 str;
    public Vector3 offset;
    public float duration;
    public float randomness;
    public int vibrato;
    public bool fadeout;
    void Start()
    {
        
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {   transform.DOKill();
        transform.TransformVector(offset);
        transform.DOShakeRotation(duration,str,vibrato,randomness,fadeout);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
