using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class CourseMedtData
    {
        [StringLength(50)]
        public string Title { get; set; }
        [Range(1,10)]
        public Nullable<int> Credits { get; set; }

    }
    [MetadataType(typeof(CourseMedtData))]
    public partial class Course
    {

    }
}