﻿namespace StateMachine
{
    public abstract class State
    {
        public SM owner;
        public bool isInit;
        public DictWrapper sharedData;
        
        public abstract void DoEnter();
        public abstract void DoExit();
        public abstract void DoUpdate();
    }
}