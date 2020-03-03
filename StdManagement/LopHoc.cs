using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagement
{
    class LopHoc
    {
        private int ID { get; set; }
        private String TenLop { get; set; }
        private String DiaChi { get; set; }

        public LopHoc() { }

        public LopHoc(String TenLop)
        {
            this.TenLop = TenLop;
        }

        public LopHoc(String TenLop, String DiaChi)
        {
            this.TenLop = TenLop;
            this.DiaChi = DiaChi;
        }

        public LopHoc(int ID, String TenLop, String DiaChi)
        {
            this.ID = ID;
            this.TenLop = TenLop;
            this.DiaChi = DiaChi;
        }

        public int getID()
        {
            return ID;
        }

        public string getTenLop()
        {
            return TenLop;
        }

        public string getDiaChi()
        {
            return DiaChi;
        }
    }
}
