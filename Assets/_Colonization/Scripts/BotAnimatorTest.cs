using System;
using System.ComponentModel;
using UnityEngine;

public class BotAnimatorTest : MonoBehaviour
{
    public event Action<Type> StateChanged;


    [ContextMenu("Walk")]
    public void Walk()
    {
        StateChanged?.Invoke(typeof(WalkState));
    }

    [ContextMenu("Idle")]
    public void Idle()
    {
        StateChanged?.Invoke(typeof(IdleState));
    }

    [ContextMenu("Mining")]
    public void Maning()
    {
        StateChanged?.Invoke(typeof(MiningState));
    }

    [ContextMenu("Drop")]
    public void Drop()
    {
        StateChanged?.Invoke(typeof(DropState));
    }
}
