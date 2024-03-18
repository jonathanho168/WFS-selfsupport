using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBusinessObjectFunction")]
[Index("BusinessObjectCode", "ExecutionType", Name = "IX_USysBusinessObjectFunctionByType_BusinessObjectCode_ExecutionType")]
public partial class UsysBusinessObjectFunction
{
    [Key]
    public Guid BusinessObjectFunctionGuid { get; set; }

    [StringLength(100)]
    public string BusinessObjectCode { get; set; } = null!;

    [StringLength(100)]
    public string FunctionCode { get; set; } = null!;

    public int ExecutionType { get; set; }

    public int RowVersion { get; set; }
}
