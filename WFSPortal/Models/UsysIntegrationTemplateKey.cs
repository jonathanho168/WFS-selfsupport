using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysIntegrationTemplateKey")]
public partial class UsysIntegrationTemplateKey
{
    [Key]
    [Column("IntegrationTemplateKeyGUID")]
    public Guid IntegrationTemplateKeyGuid { get; set; }

    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LoadDate { get; set; }

    [StringLength(80)]
    public string VendorType { get; set; } = null!;

    [StringLength(80)]
    public string Vendor { get; set; } = null!;

    [StringLength(80)]
    public string VendorSoftwareVersion { get; set; } = null!;

    [Column("HCMIntegrationVersion")]
    [StringLength(80)]
    public string HcmintegrationVersion { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("UsysIntegrationTemplateKeys")]
    public virtual UsysLnkExportMaster Export { get; set; } = null!;
}
