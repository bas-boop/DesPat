using StateMachine;
using UnityEngine;

namespace AI
{
    public sealed class IdleState : State
    {
        public override void DoEnter()
        {
            Debug.Log("Started doing nothing");
        }

        public override void DoExit()
        {
            Debug.Log("Stopped doing nothing");
        }

        public override void DoUpdate()
        {
            
        }
    }
}