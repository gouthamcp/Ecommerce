﻿using GroceryStore_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore_Backend.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();

    }
}