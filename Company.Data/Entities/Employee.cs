﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class Employee:IEntity
{
    public int Id { get; set; }
    [MaxLength(80), Required]
    public string? FirstName { get; set; }
    [MaxLength(80), Required]
    public string? LastName { get; set; }
    public decimal? Salary { get; set; }
    [Required]
    public bool? Union { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department? Department { get; set; }
    public virtual ICollection<Position>? Positions { get; set; }
}
