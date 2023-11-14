using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example3
{
    public class PersonList : IList, IEqualityComparer
    {
        List<Person> persons = new List<Person>();

        public object? this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsFixedSize => false;

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public int Add(object? value)
        {
            try
            {
                if (value != null)
                {
                    persons.Add((Person)value);
                    return Count - 1;
                }
                else return -1;
            }
            catch
            {
                return -1;
            }
        }

        public new bool Equals(object? x, object? y)
        {
            if (((Person)x).GetHashCode() == ((Person)y).GetHashCode())
            {
                return true;
            }
            else return false;
        }

        public void Clear()
        {
            persons.Clear();
        }

        public bool Contains(object? value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }



        public int GetHashCode(object obj)
        {
            return ((Person)obj).Id.GetHashCode();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }



        public int IndexOf(object? value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object? value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object? value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
