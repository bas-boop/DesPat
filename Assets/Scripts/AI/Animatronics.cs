using Event;
using StateMachine;
using UnityEngine;
using EventType = Event.EventType;

namespace AI
{
    public class Animatronic
    {
        private SM _stateMachine;

        private IdleState _idleState = new ();
        private MovingState _movingState = new ();
        
        private string _name;
        private int _startCamera;
        private int _currentCamera;
        private int _respawnCamera;
        private int _level;
        private int[] _path;

        public void Start()
        {
            EventManager.AddListener(EventType.TIME, () => Debug.Log("Ar ar ar ar"));
            EventManager.AddListener(EventType.MOVE_MOMENT, CheckMovement);

            _stateMachine = new (new State[] {_idleState, _movingState});
            
            _stateMachine.sharedData.Set("name", _name);
            _stateMachine.sharedData.Set("currentCamera", _currentCamera);
            _stateMachine.sharedData.Set("path", _path);
            _stateMachine.SwitchState(_idleState);
        }

        private void CheckMovement()
        {
            int r = Random.Range(1, 20);
            
            if (r <= _level)
                _stateMachine.SwitchState(_movingState);
        }
        
        public class AnimatronicBuilder
        {
            private readonly Animatronic _animatronic = new ();

            public AnimatronicBuilder SetName(string name)
            {
                _animatronic._name = name;
                return this;
            }
            
            public AnimatronicBuilder SetStartCamera(int startCam)
            {
                _animatronic._startCamera = startCam;
                return this;
            }
            
            public AnimatronicBuilder SetRespawnCamera(int respawnCam)
            {
                _animatronic._respawnCamera = respawnCam;
                return this;
            }
            
            public AnimatronicBuilder SetLevel(int level)
            {
                _animatronic._level = level;
                return this;
            }

            public AnimatronicBuilder SetPath(int[] path)
            {
                _animatronic._path = path;
                return this;
            }

            public Animatronic Build()
            {
                return _animatronic;
            }
        }
    }
}