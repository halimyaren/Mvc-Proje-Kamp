using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; }  //Heading i Category'e bağlamak için gerekli kodlar.
        public virtual Category Category{ get; set; }

        public ICollection<Content> Contents { get; set; }  //Heading sınıfını Content'e bağlamak için eklendi.
                                                            //Başlık bir içeriğe aittir!

        public int WriterID { get; set; }      //Heading sınıfını Writer sınıfına bağladık.
        public virtual Writer Writer { get; set; }
    }
}
