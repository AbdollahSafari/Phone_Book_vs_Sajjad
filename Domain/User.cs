using System.ComponentModel;

namespace Domain;

public class User : SeedWork.Entity
{

    #region Constructor
  
    public User()
    {
        
    }

    #endregion /Constructor

    #region 


    public string? Name { get; set; }

    [DisplayName ("Last Name")]
    public string? LastName { get; set; }

    public string? Position { get; set; }

    [Browsable(false)]
    [DisplayName("Office Phone Number")]
    public string? OfficePhone { get; set; }

    [Browsable (false)]
    [DisplayName("Mobile Number")]
    public string? MobilePhone { get; set; }

    #endregion /
 
}

