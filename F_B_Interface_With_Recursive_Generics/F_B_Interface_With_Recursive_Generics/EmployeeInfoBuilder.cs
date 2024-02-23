using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_B_Interface_With_Recursive_Generics
{
    public class EmployeeInfoBuilder<T> : EmployeeBuilder where T: EmployeeInfoBuilder<T>
    {
        protected Employee employee = new Employee();

        public T SetName(string name)
        {
            employee.Name = name;
            return (T)this;
        }
    }
}
