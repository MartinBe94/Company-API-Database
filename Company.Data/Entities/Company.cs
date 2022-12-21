using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class Company:IEntity
{
    public int Id { get; set; }
    [MaxLength(80), Required]
    public string? CompanyName { get; set; }
    [MaxLength(80), Required]
    public string? OrganisationNumber { get; set; }
}
