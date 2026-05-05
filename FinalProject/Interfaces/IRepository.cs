using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Interfaces
{
    internal interface IRepository<T>
    {
        void Add(T order);
        T getById(string id);
        List<T> getAll();

    }
}
