using System;
namespace GJP.Game.Core.Machines
{
    public class StateMachine<T> : IStateMachine<T>
    {
        private T _owner;
        public IState<T> CurrentState { get; set; }
        public IState<T> PreviousState { get; set; }
        public IState<T> GlobalState { get; set; }

        public StateMachine()
        {
            CurrentState = null;
            PreviousState = null;
            GlobalState = null;
        }

        public void SetOwner(T owner)
        {
            _owner = owner;
        }


        public void Update()
        {
            if (GlobalState != null)
                GlobalState.Execute(_owner);
            if (CurrentState != null)
                CurrentState.Execute(_owner);
        }

        public void ChangeState(IState<T> newState)
        {
            if (newState == null)
                throw new Exception("<StateMachine::ChangeState>: trying to change to a null state");
            if (CurrentState == null)
                throw new Exception("<StateMachine::ChangeState>: current state is null");

            PreviousState = CurrentState;
            CurrentState.Exit(_owner);
            CurrentState = newState;
            CurrentState.Enter(_owner);
        }


        public void SetState(IState<T> newState)
        {
            CurrentState = newState;
        }
    }
}
