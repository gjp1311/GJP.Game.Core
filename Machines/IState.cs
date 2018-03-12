namespace GJP.Game.Core.Machines
{
    public interface IState<T>
    {
        void Enter(T entity);
        void Execute(T entity);
        void Exit(T entity);
    }
}
