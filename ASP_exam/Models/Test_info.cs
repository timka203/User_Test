namespace ASP_exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test_info
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
      
        public string LastName { get; set; }

        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        public DateTime? Test_Date { get; set; }

        public DateTime? Test_start { get; set; }

        public DateTime? Test_end { get; set; }

        public int? Right_ans { get; set; }
    }
}
