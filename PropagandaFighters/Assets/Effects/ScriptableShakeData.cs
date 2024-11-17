using UnityEngine;
namespace Shakfy.Core
{
    public class ScriptableShakeData : ScriptableObject
    {
        public string Id;
        public string Name;
        public float FPS;
        public AnimationCurve PosX;
        public AnimationCurve PosY;
        public AnimationCurve PosZ;
        public AnimationCurve RotX;
        public AnimationCurve RotY;
        public AnimationCurve RotZ;
    }
}