﻿using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vezeeta.DBL;

namespace vezeeta.DBL;

public class DepartmentRepo : GenericRepo<Department>, IDepartmentRepo
{
    private VezeetaDB vezeetaDB;
    public DepartmentRepo(VezeetaDB _vezeetaDB) : base(_vezeetaDB)
    {
        vezeetaDB = _vezeetaDB;
    }
    public bool Find(Department department, bool checkName = true)
    {
        if (checkName is true)
        {
            bool check = _Any().Any(d => d.name_ar == department.name_ar || d.name_en == department.name_en);
            return check;
        }
        return _Any().Any(d => d.Id == department.Id);
    }
}
