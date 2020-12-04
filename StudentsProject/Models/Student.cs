using StudentsProject.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentsProject.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fullname is required.")]
        public string Fullname { get; set; }

        [Required(ErrorMessage ="The email adress is required.")]
        [EmailAddress(ErrorMessage ="Invalid email adress" )]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required.")]
        [MacedonianMobilePhone (ErrorMessage = "Macedonian phone number must be in format : +389XXXXXXXX. " +
            "So it starts with +389 and contains 8 more digits")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Must be unique.
        /// </summary>
        [Range(1000, long.MaxValue, ErrorMessage = "Student number must be greater than 1000.")]
        [Index("IX_StudentNumberIsUnique", IsUnique = true)]
        public int StudentNumber { get; set; }

        /// <summary>
        /// Student subjects connections.
        /// </summary>
        public virtual List<StudentSubject> StudentSubjects { get; set; }
    }
}