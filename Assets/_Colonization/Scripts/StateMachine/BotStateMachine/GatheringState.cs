using UnityEngine;

public class GatheringState : IState
{
    private readonly BotStateMachine _stateMachine;

    private float _animationDuration;

    public GatheringState(BotStateMachine stateMachine) =>    
        _stateMachine = stateMachine;    

    public void Enter()
    {
        _animationDuration = 2.2f;

        if (_stateMachine.Bot.CurrentResource != null && _stateMachine.Inventory.IsFull == false)        
            _stateMachine.Inventory.Add(_stateMachine.Bot.CurrentResource);        
    }

    public void Exit() { }

    public void Update()
    {
        _animationDuration -= Time.deltaTime;

        if (_stateMachine.Inventory.IsFull && _animationDuration <= 0)        
            _stateMachine.TransitionTo<WalkState>();        
    }
}