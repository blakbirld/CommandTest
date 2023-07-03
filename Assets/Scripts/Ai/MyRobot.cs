using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRobot : BaseAi
{
    public Renderer RendererComponent;

    public override void StartActions()
    {
        StartCoroutine(CoroutineStartAction());
    }

    private IEnumerator CoroutineStartAction()
    {
        for (int i = 0; i < AllCommands.Count; i++)
        {
            AllCommands[i].Execute();
            yield return new WaitForSeconds(AllCommands[i].Time);
        }
    }

}
