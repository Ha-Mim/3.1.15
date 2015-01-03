using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExample.Entity
{
    class Student
    {
        Course aCourse = new Course();

        public void N1()
        {
            aCourse.A = aCourse.B;
            aCourse.M1();
            aCourse.M2();
        }
    }
}
