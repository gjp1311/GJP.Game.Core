using System.Collections.Generic;

namespace GJP.Game.Core.Matcher
{
    public class OptionMatcher<T>
    {
        private List<IOption<T>> _options;

        public OptionMatcher()
        {
            _options = new List<IOption<T>>();
        }

        public void AddOption(IOption<T> option)
        {
            _options.Add(option);
        }

        public void AddOptions(List<IOption<T>> options)
        {
            _options.AddRange(options);
        }

        public T HandleOptions(string value)
        {
            foreach (var option in _options)
            {
                if (option.Match(value))
                    return option.Result();
            }
            return default(T);
        }
    }
}
