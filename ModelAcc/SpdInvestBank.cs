using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdInvestBank
    {

        public string Code { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string AccNo { get; set; }
        public string DestinationCode { get; set; }
    }
}
