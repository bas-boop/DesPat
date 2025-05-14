namespace StateMachine
{
    public sealed class SM
    {
        private State _currentState;
        public DictWrapper sharedData;

        public void UpdateState() => _currentState.DoUpdate();

        public void SwitchState(State targetState)
        {
            if (_currentState != null)
                _currentState.DoExit();
            
            if (!targetState.isInit)
                InitState(targetState);
            
            _currentState = targetState;
            _currentState.DoEnter();
        }

        private void InitState(State targetState)
        {
            targetState.sharedData = sharedData;
            targetState.isInit = true;
        }
    }
}