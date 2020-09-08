﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace DataAccess.Contracts
{
    public interface IUserRepository:IGenericRepository<UserLoginCache>
    {

    }
}
