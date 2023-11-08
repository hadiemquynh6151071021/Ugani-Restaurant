﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ugani_Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class AspNetUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUser()
        {
            this.AspNetUserClaims = new HashSet<AspNetUserClaim>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogin>();
            this.AspNetRoles = new HashSet<AspNetRole>();
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public string Id { get; set; }
        [DisplayName("Tên tài khoản")]
        [Required(ErrorMessage = "Vui lòng nhập tên tài khoản trước khi xác nhận!")]
        [EmailAddress(ErrorMessage = "Tên tài khoản là Email!")]
        public string UserName { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email trước khi xác nhận!")]
        [EmailAddress(ErrorMessage = "Đây phải là Email!")]
        public string Email { get; set; }
        [DisplayName("Xác nhân Email")]
        [Required(ErrorMessage = "Vui lòng nhập lại Email trước khi xác nhận!")]
        [EmailAddress(ErrorMessage = "Đây phải là Email!")]
        public bool EmailConfirmed { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Vui lòng nhập lại Mật khẩu trước khi xác nhận!")]
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Số điện thoại không hợp lệ. Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.")]
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        [DisplayName("Họ và tên")]
        public string FullName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
