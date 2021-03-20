using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public List<AnimationCurve> animationCurves;
    public Vector3[] points;
    public float disx=0;
    public float disy=0;
    public float disz=0;
    public float duration=3;

    public int type = 0;

    
    void Start()
    {
        Debug.Log("start");
    }

    void OnEnable()
    {
        disx=-disx;
        disy=-disy;
        disz=-disz;
        Debug.Log("enable");
        transform.DOKill();
        if (type == 0)
        {
            transform.DOLocalMoveX(disx, duration).SetEase(animationCurves[0]);
            transform.DOLocalMoveY(disy, duration).SetEase(animationCurves[1]);
            transform.DOLocalMoveZ(disz, duration).SetEase(animationCurves[2]);;
        }
        if(type==1)
            transform.DOPunchScale(points[0], 3f,3,0.7f);
        if(type==2)
            transform.DOLocalPath(points,duration,DG.Tweening.PathType.CatmullRom);
        this.enabled = false;
    }

    void Awake(){
        Debug.Log("awake");
    }


    private float EaseFun(float time, float duration, float overshootOrAmplitude, float period)
    {
        return time / duration;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
