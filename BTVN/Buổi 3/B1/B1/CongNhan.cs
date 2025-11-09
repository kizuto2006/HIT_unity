using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    private enum ChucVu
    {
        TruongNhom,
        PhoNhom,
        CongNhanBac3,
        CongNhanBac2,
        CongNhanBac1,
        Khac
    }
    internal class CongNhan : Person
    {
        private string MaCongNhan
        {
            get { return MaCongNhan; }
            set { MaCongNhan = value; }
        }
        public ChucVu chucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public CongNhan() { }
        public CongNhan(string MaCongNhan,string fullname,int age,string add,ChucVu chucVu) : base(fullname,age,add)
        {
            this.MaCongNhan= MaCongNhan;
            this.chucVu = chucVu;
        }

        public double TinhLuong()
        {
            double mult = 1.0;
            switch(chucVu)
            {
                case ChucVu.TruongNhom:     mult = 3.0; break;
                case ChucVu.PhoNhom:        mult = 2.5; break;
                case ChucVu.CongNhanBac1:   mult = 2.0; break;
                case ChucVu.CongNhanBac2:   mult = 1.5; break;
                case ChucVu.CongNhanBac3:   mult = 1.2; break;
                case ChucVu.Khac:           mult = 1.0; break;

            }
            return mult * 8000000;
        }
     
    }

}