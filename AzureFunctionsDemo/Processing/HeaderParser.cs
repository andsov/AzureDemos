using Microsoft.AspNetCore.Http;

namespace AzureFunctionsDemo.Processing
{
    public class HeaderParser<T> : IHeaderParser<T>
        where T : class, new()
    {
        public T Parse(IHeaderDictionary headerDictionary)
        {
            var t = new T();

            t.GetType();

            //foreach(var propName in t.)

            return t;
        }
    }

    public interface IHeaderParser<T>
        where T : class, new()
    {
        T Parse(IHeaderDictionary headerDictionary);
    }
}
