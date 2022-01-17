using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }

        public string PhoneNumber { get; set; }

        public Advisor AssignedAdvisor { get; set; }
    }
}
