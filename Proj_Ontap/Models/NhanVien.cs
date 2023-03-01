namespace Proj_Ontap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public int Manv { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage ="Họ tên không được để trống!")]
        public string Hoten { get; set; }

        [Required(ErrorMessage = "Tuổi không được để trống!")]
        public int? Tuoi { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string Diachi { get; set; }

        [Required(ErrorMessage = "Lương không được để trống!")]
        public int? Luong { get; set; }

        public int? Maphong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
