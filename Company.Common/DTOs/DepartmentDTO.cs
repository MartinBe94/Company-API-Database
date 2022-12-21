using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs;

public class DepartmentDTO
{
    public int Id { get; set; }
    [MaxLength(80), Required]
    public string? DepartmentName { get; set; }
    public int CompanyId { get; set; }
}
