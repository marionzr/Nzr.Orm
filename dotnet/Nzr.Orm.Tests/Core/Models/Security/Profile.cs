﻿
using Nzr.Orm.Core.Attributes;
using System;

namespace Nzr.Orm.Tests.Core.Models.Security
{
    /// <summary>
    /// This entity maps to a table that follows one of supported naming convention: LowerCaseUnderlined.
    /// Also its id, defined in the Base class, also maps to a known id pattern: id_table.
    /// In this case there is no need of use attributes to decorate the entity or properties.
    ///
    /// But since the table this entity maps to is not in the same schema of other tables,
    /// you can set the schema here to avoid changing the default schema defined in the Dao instance.
    /// </summary
    [Table(schema: "security")]
    public class Profile : BaseEntity
    {
        /// <summary>
        /// Hidding the BaseEntity.Id to configure this Property as auto-generated
        /// </summary>
        [Key(autoGenerated: true)]
        public new Guid Id { get; set; }

        public string Permissions { get; set; }
    }
}
