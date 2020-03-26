using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Domain.Model
{
    public class Operation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double ExecutionTime { get; set; }
        public DateTime ExecutionDate  { get; set; }


    }
}
