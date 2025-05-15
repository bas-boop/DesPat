using Event;
using StateMachine;
using UnityEngine;
using EventType = Event.EventType;

namespace AI
{
    public class Animatronic
    {
        private SM _stateMachine;

        private string _name;
        private int _startCamera;
        private int _currentCamera;
        private int _respawnCamera;
        private int _level;
        private int[] _path;

        public void Start()
        {
            EventManager.AddListener(EventType.TIME, () => Debug.Log("Ar ar ar ar"));
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