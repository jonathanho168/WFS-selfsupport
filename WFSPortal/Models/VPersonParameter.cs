using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VPersonParameter
{
    [Column("PersonParametersGUID")]
    public Guid PersonParametersGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonPicker_DisplayID")]
    public string? PersonPickerDisplayId { get; set; }
}
