﻿using Mission.Entities;
using Mission.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IServices
{
    public interface IAdminUserService
    {
        List<UserDetails> UserDetailsList();
        string UserDelete(int id);
       
        //User GetUserDetailById(int id);
    }
}
