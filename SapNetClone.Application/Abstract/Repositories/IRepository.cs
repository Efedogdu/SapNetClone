﻿using Microsoft.EntityFrameworkCore;
using SapNetClone.Entities.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapNetClone.Application.Abstract.Repositories
{
    public interface IRepository<T> where T : BaseObject
    {
        DbSet<T> Table { get; }
    }
}
