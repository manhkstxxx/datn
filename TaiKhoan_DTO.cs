using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private int sMaTK;

        public int SMaTK
        {
            get { return sMaTK; }
            set { sMaTK = value; }
        }
        private int sMaNV;

        public int SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        private string sPass;

        public string SPass
        {
            get { return sPass; }
            set { sPass = value; }
        }
    }
}
