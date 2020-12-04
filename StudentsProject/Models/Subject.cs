using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentsProject.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Subject name is required.")]
        public string Name { get; set; }

        /// <summary>
        /// Creditns must be 2-8 credits.
        /// </summary>
        [Range(2, 8, ErrorMessage = "Subject can have minimum 2 or maximum 8 credits.")]
        public int Credits  { get; set; }

        /// <summary>
        /// Semestar must be 1-8.
        /// </summary>
        [Range(1,8, ErrorMessage = "Semestar must be from 1 to 8." )]
        public int Semester { get; set; }

        /// <summary>
        /// Subject students connections.
        /// </summary>
        public virtual List<StudentSubject> SubjectStudents { get; set; }
    }
}