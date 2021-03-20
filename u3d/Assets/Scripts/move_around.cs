using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_around : MonoBehaviour
{
    public GameObject target;		//目标中心
    public float speed = 0.5f;			//旋转速度


    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, speed);
    }
}
