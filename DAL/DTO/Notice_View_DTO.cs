using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class Notice_View_DTO
    {
        public int N_ID { get; set; } // notce id
        public string N_TITEL { get; set; } // notice titel
        public string P_EMP_NAME { get; set; } // notice put name

        public int? position_id { get; set; }
        public string Position_name { get; set; } // put position name
        public DateTime? N_DATE { get; set; } // notice date

    }
    public class notice_notification
    {
        public static int Count { get; set; }
    }
}
