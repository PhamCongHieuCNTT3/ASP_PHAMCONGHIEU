using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCH_lesson06.Models
{
    public class PCHSong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "PCH: Hãy Nhập Tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string PCHTitle { get; set; }
        [Required(ErrorMessage ="PCH: Hãy Nhập Tác Giả")]
        [DisplayName("Tác Giả")]
        public string PCHAuthor { get; set; }
        [Required(ErrorMessage ="PCH: Hãy Nhập Nghệ Sĩ")]
        [StringLength(50,MinimumLength = 2,ErrorMessage ="PCH: Tên nghệ sĩ có tối thiểu 2 kí tự và tối đa 50 kí tự ")]
        [DisplayName("nghệ sĩ")]
        public string PCHArtist { get; set; }
        [Required(ErrorMessage ="PCH: hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="PCH: nhập nhà xuất bản có 2 kí tự số")]
        [Range(1900,2024,ErrorMessage ="PCH: năm xuất bản trong khoảng năm 1900-2024")]
        [DisplayName("năm xuất bản")]
        public string PCHYearRelease { get; set;}
    }
}