﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
   public class Work_info_DTO
    {
        public List<Work_Emp_Detail_DTO> Work_emp_Detail { get; set; }

        public List<Report_Emp_Detail> Report_Emp_Detail { get; set; }

        public List<Notice_View_DTO> Notice { get; set; }
    }
}
