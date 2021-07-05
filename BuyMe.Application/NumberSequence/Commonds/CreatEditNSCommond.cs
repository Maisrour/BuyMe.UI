﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMe.Application.NumberSequence.Commonds
{
    public class CreatEditNSCommond:IRequest<int>
    {
        public int? NumberSequenceId { get; set; }
        public string NumberSequenceName { get; set; }
        public string Module { get; set; }
        public string Prefix { get; set; }
        public int? LastNumber { get; set; }
        public int CompanyId { get; set; }
    }
}
