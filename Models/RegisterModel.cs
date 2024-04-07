using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Demo.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$|^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}", ErrorMessage = "Please enter a valid email address")]
        public string email { get; set; }
        public string password { get; set; }
        [Compare("password",ErrorMessage ="password doesnt match")]
        public string confirmpassword {  get; set; }
        [MaxLength(10)]
        public string phNumber {  get; set; }
        public string course { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateOnly DOB { get; set; }

    }
}
