using FinalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public override IEnumerable<Operation> GetAll()
        {
            var obj = base.GetAll();

            return obj.OrderByDescending(x => x.ExecutionDate);
        }

        public override void Add(Operation obj)
        {
            obj.Id = Guid.NewGuid();
            obj.ExecutionDate = DateTime.Now;

            base.Add(obj);
          
        }

    }
}
