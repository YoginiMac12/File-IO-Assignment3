﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODepartment
{
    [Serializable]  // attribute in C#
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }


    }
 }

