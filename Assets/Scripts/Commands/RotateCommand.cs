using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCommand : Icommand
{
    private Transform objTransform = null;
    private Vector3 targetPosRotation = Vector3.zero;
    private float time = 0;

    public RotateCommand(Transform _obj, Vector3 _pos, float _time)
    {
        time = _time;
        objTransform = _obj;
        targetPosRotation = _pos;
    }

    public float Time => time;

    public void Execute()
    {
        // made simple Rotate()
        // to move smoothly we can use DOTTween  DoRotate  or Quaternion.Lerp  and move logic to Coroutine or update
        if (objTransform != null)
        {
            objTransform.Rotate(targetPosRotation);
        }
    }
}
