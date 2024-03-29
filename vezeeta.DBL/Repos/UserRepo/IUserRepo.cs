﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vezeeta.DBL;

namespace vezeeta
{
    public interface IUserRepo : IGenericRepo<User>
    {
        public virtual void ActivateUser(User user) { }
        public bool IsActive(User user);
        public bool Find(User user, bool checkName = true);
    }
}
