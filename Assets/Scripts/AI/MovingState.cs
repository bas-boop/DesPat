using StateMachine;
using UnityEngine;

namespace AI
{
    public sealed class MovingState : State
    {
        public override void DoEnter()
        {
            Debug.Log("Started walking");

            int i = sharedData.Get<int>("currentCamera");
            int[] path = sharedData.Get<int[]>("path");
            
            i++;

            if (path.Length < i)
                i = 0;
            
            sharedData.Set("currentCamera", path[i]);
            
            owner.SwitchState(sharedData.Get<IdleState>("idleState"));
        }

        public override void DoExit()
        {
            Debug.Log("Stopped walking");
        }

        public override void DoUpdate()
        {
            
        }
    }
}