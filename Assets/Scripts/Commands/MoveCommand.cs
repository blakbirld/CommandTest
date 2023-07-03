using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Icommand
{
    private Transform objTransform = null;
    private Vector3 targetPos = Vector3.zero;
    private float time = 0;

    public MoveCommand(Transform _obj, Vector3 _pos, float _time)
    {
        time = _time;
        objTransform = _obj;
        targetPos = _pos;
    }

    public float Time => time;

    public void Execute()
    {
        // made simple Translate()
        // to move smoothly we can use DOTTween  DoMove  or Vector3.Lerp  and move logic to Coroutine or update
        if (objTransform != null)
        {
            objTransform.Translate(targetPos);
        }
    }
}
