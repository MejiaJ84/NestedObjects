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

        /// <summary>
        /// The student's date of birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Student's preferred contact number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The advisor assigned to the student
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
