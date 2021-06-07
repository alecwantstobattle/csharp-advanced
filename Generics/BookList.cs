using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {

            get { throw new NotImplementedException(); }
        }
    }

    //public class ObjectList // we can pass any type cos object is the parent class, or get any type in the indexer
    //{                       // has performance penalty cos you need to box/unbox to store/access
    //    public void Add(object value)
    //    {

    //    }

    //    public object this[int index]
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
