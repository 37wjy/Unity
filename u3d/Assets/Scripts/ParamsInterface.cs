using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bole
{
    [XLua.LuaCallCSharp]
    public class ParamsInterface : MonoBehaviour
    {
        public List<AnimationCurve> animationCurves=new  List<AnimationCurve>();
        public List<Vector3> points_v3=new  List<Vector3>();
        public List<Vector2> points_v2=new  List<Vector2>();
        public List<float> numbers=new  List<float>();

        public List<AnimationCurve> GetAnimationCurves(){
            return animationCurves;
        }

        public List<Vector3> GetVector3s(){
            return points_v3;
        }

        public List<Vector2> GetVector2s(){
            return points_v2;
        }

        public List<float> GetNumbers(){
            return numbers;
        }
    }
}
