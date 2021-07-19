using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class focus_camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public Vector3 cameraOffset;
    public Vector3 rotation;
    public GameObject tar; 
    private  Transform child;
    void Start()
    {
        child=gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {
        child.localPosition=cameraOffset;
        child.eulerAngles=rotation;
        transform.position=tar.transform.position+offset;
        transform.LookAt(tar.transform);//public void LookAt(Transform target, Vector3 worldUp = Vector3.up);
    }
}
