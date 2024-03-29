﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs;

public class PositionDTO
{
    public int Id { get; set; }
    [MaxLength(80), Required]
    public string? PositionName { get; set; }
}
