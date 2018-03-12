namespace GJP.Game.Core.Matcher
{
    public interface IOption<T>
    {
        bool Match(string value);
        T Result();
    }
}
