using FinalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Data
{
    public class OperationRepository : Repository<Operation>
    {
        public OperationRepository(FinalProjectContext context)  
            : base(context)
        {

        }

        public FinalProjectContext CourseEnrollmentContext
        {
            get { return _context as FinalProjectContext; }
        }
    }
}
