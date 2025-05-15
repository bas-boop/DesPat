using StateMachine;
using UnityEngine;

namespace AI
{
    public sealed class IdleState : State
    {
        public override void DoEnter()
        {
            Debug.Log($"Started {sharedData.Get<string>("name")} doing nothing");
        }

        public override void DoExit()
        {
            Debug.Log($"Stopped {sharedData.Get<string>("name")} doing nothing");
        }

        public override void DoUpdate()
        {
            
        }
    }
}