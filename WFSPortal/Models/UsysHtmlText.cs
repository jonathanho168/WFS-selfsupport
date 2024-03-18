using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysHtmlText")]
[Index("ModuleDefinitionGuid", Name = "IX_USysHTMLText_ModuleDefinitionGUID")]
[Index("HtmlTextGuid", Name = "RG_USysHtmlText", IsUnique = true)]
public partial class UsysHtmlText
{
    [Key]
    [Column("HtmlTextGUID")]
    public Guid HtmlTextGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("ModuleDefinitionGUID")]
    public Guid? ModuleDefinitionGuid { get; set; }

    public string? DesktopHtml { get; set; }

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysHtmlTexts")]
    public virtual UsysModuleDefinition? ModuleDefinition { get; set; }
}
