using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationAnnotations
{
    public class UserProperties
    {
        [Required (ErrorMessage = "{0} is required")]
        [StringLength(60,MinimumLength = 3, ErrorMessage ="First name should be minimum 3 characters")]
        [RegularExpression(@"^[A-Z][a-z]{2,}$",ErrorMessage ="Not Valid First Name")]
        [DataType(DataType.Text)]
        public string FirstName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Last name should be minimum 3 characters")]
        [RegularExpression(@"^[A-Z][a-z]{2,}$", ErrorMessage = "Not Valid Last Name")]
        [DataType(DataType.Text)]
        public string LastName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(^[a-z]+)(([\. \+ \-]?[a-z A-Z 0-9])*)@(([0-9 a-z]+[\.]+[a-z]{3})+([\.]+[a-z]{2,3})?$)", ErrorMessage = "Not a valid Email")]
        [EmailAddress]
        public string Email
        {
            get;
            set;
        }
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[91]+[\s]+[0-9]{10}$", ErrorMessage = "Not a valid Phone Number")]
        [Phone]
        public string PhoneNumber
        {
            get;
            set;
        }
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$", ErrorMessage = "Not a valid Password")]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }
    }

}
