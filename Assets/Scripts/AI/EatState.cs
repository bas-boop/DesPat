using StateMachine;
using UnityEngine;

namespace AI
{
    public sealed class EatState : State
    {
        public override void DoEnter()
        {
            Debug.Log("Started to enjoy some food");
        }

        public override void DoExit()
        {
            Debug.Log("Plate is empty");
        }

        public override void DoUpdate()
        {
            
        }
    }
}