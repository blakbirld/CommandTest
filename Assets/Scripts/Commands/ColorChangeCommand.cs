using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeCommand : Icommand
{
    private Renderer objRender = null;
    private Color targetColor = Color.white;
    private float time = 0;

    public ColorChangeCommand(Renderer _obj, Color _pos, float _time)
    {
        time = _time;
        objRender = _obj;
        targetColor = _pos;
    }

    public float Time => time;

    public void Execute()
    {
        if (objRender != null)
        {
            objRender.material.SetColor("_Color", targetColor);
        }
    }
}
