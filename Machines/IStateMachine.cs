namespace GJP.Game.Core.Machines
{
    public interface IStateMachine<T>
    {
        void Update();
        void SetState(IState<T> newState);
        void ChangeState(IState<T> newState);
        void SetOwner(T owner);
    }
}
