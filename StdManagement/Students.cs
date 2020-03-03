using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagement
{
    class Students
    {
        private int ID;
        private String MaSV;
        private String TenSV;
        private String TenLop;
        private int Tuoi;
        private String DiaChi;

        public string getMaSV()
        {
            return MaSV;
        }

        public int getID()
        {
            return ID;
        }

        public string getTenSV()
        {
            return TenSV;
        }

        public string getTenLop()
        {
            return TenLop;
        }

        public int getTuoi()
        {
            return Tuoi;
        }

        public string getDiaChi()
        {
            return DiaChi;
        }

        public Students() { }

        public Students(String MaSV, String TenSV)
        {
            this.MaSV = MaSV;
            this.TenSV = TenSV;
        }

        public Students(String MaSV, String TenSV, String TenLop, int Tuoi, String DiaChi)
        {
            this.MaSV = MaSV;
            this.TenSV = TenSV;
            this.TenLop = TenLop;
            this.Tuoi = Tuoi;
            this.DiaChi = DiaChi;
        }

        public Students(int ID, String MaSV, String TenSV, String TenLop, int Tuoi, String DiaChi)
        {
            this.ID = ID;
            this.MaSV = MaSV;
            this.TenSV = TenSV;
            this.TenLop = TenLop;
            this.Tuoi = Tuoi;
            this.DiaChi = DiaChi;
        }
    }
}
