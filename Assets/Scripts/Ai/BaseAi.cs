using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAi : MonoBehaviour
{
    protected List<Icommand> AllCommands = new List<Icommand>();

    protected void Awake()
    {
        AllCommands = new List<Icommand>();
    }

    public abstract void StartActions();
 
    public virtual void ClearCommands()
    {
        AllCommands.Clear();
    }

    public virtual void RegisterCommand(Icommand _newComand)
    {
        AllCommands.Add(_newComand);
    }

    public virtual void RegisterCommands(List<Icommand> _newComands)
    {
        AllCommands.AddRange(_newComands);
    }

}
