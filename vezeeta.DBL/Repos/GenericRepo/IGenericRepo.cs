﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezeeta.DBL;

public interface IGenericRepo<T>
{
    public List<T> Index();
    public T? Show(Guid id);
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public void SaveChanges();

}
