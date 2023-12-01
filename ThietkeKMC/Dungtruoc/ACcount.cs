using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietkeKMC.Dungtruoc
{
    public class ACcount
    {
        private static ACcount instance;

        public static ACcount Instance {
            get
            {
                if (instance == null)

                {
                    instance = new ACcount();
                }

                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public bool Login(string tk,string mk)
        {
            string query = "dangnhap2 @username , @pass ";
            DataTable kq = Datapro1.Instances.Xem(query, new object[] { tk, mk });
            return kq.Rows.Count >0;
        }
       
    }
}
