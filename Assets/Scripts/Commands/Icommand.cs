using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Icommand
{
    float Time
    {
        get;
    }
    void Execute();
}
