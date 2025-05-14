using StateMachine;
using UnityEngine;

namespace AI
{
    public sealed class SleepState : State
    {
        public override void DoEnter()
        {
            Debug.Log("Started sleeping");
        }

        public override void DoExit()
        {
            Debug.Log("Woke up");
        }

        public override void DoUpdate()
        {
            
        }
    }
}