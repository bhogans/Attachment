using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Attachment
{
    public class AttachmentItem
    {
        public int DocumentId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string FileType { get; set; }

        public int MyProperty { get; set; }

        //[Range(typeof(DateTime), "01/01/2000", "12/01/2022",
        //    ErrorMessage ="Valid dates for the Property {0} between {1} and {2}")]
        public DateTime CreatedOn { get; set; }
    }
}
