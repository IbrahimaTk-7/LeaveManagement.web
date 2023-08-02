using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Models;

public class LeaveTypeVM
{
    public int Id { get; set; }
    [Display(Name = "Leave Type Name")]

    public string Name { get; set; }

    [Display(Name = "Default Number Of Days")]

    public int DeafaultDays { get; set; }
}
