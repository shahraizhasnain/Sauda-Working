﻿using SaudaMaster.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Infrastructure.Common
{
    public interface IUnityOfWork
    {
        IDatabaseFactory instance { get; }
        saudadbEntities db { get; }
        void Commit();
    }
}
