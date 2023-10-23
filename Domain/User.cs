using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User : SeedWork.Entity
{

    #region Constructor
  
    public User()
    {
        
    }

    #endregion /Constructor

    #region 

    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 40, MinimumLength = 3)]
    public string? Name { get; set; }

    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 60, MinimumLength = 3)]
    [DisplayName ("Last Name")]
    public string? LastName { get; set; }

    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 60, MinimumLength = 3)]
    public string? Position { get; set; }

    [RegularExpression(pattern: "^\\d{11}$")]
    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 11, MinimumLength = 5)]
    [Browsable(false)]
    [DisplayName("Office Phone Number")]
    public string? OfficePhone { get; set; }

    [RegularExpression(pattern: "^\\d{11}$")]
    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 11, MinimumLength = 9)]
    [Browsable (false)]
    [DisplayName("Mobile Number")]
    public string? MobilePhone { get; set; }

    #endregion /
 
}

