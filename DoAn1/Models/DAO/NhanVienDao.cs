﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.DAO
{
    public class NhanVienDao
    {
        DbContextVB db = null;
        public NhanVienDao()
        {
            db = new DbContextVB();
        }


    }

}
