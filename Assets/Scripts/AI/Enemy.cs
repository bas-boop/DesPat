using StateMachine;

namespace AI
{
    public sealed class Enemy
    {
        private SM _stateMachine;

        private IdleState _idleState;
        private EatState _eatState;
        private SleepState _sleepState;

        public void Start()
        {
            _stateMachine = new SM();
            _idleState = new IdleState();
            _eatState = new EatState();
            _sleepState = new SleepState();
            _stateMachine.SwitchState(_idleState);
        }

        public void ChangeBehaviour(int behaviour)
        {
            switch (behaviour)
            {
                case 0:
                    _stateMachine.SwitchState(_idleState);
                    break;
                
                case 1:
                    _stateMachine.SwitchState(_eatState);
                    break;
                
                case 2:
                    _stateMachine.SwitchState(_sleepState);
                    break;
            }
        }
    }
}