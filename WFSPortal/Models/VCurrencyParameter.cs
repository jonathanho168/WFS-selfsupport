﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VCurrencyParameter
{
    [Column("CurrencyParametersGUID")]
    public Guid CurrencyParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? CorporateCurrencyCode { get; set; }
}
