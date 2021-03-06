﻿using System;

namespace Nzr.Orm.Core.Attributes
{
    /// <summary>
    /// Represents the database column that a property will be mapped to.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class ColumnAttribute : BaseAttribute
    {
        /// <summary>
        /// The zero-based order of the column.
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// The specific data type of the column the property.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Indicates that the property (if non primitive) should be serialized (as json) before saving.
        /// </summary>
        public bool Serialize { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="order">The zero-based order of the column.</param>
        /// <param name="typeName">The specific data type of the column the property.</param>
        /// <param name="serialize">Indicates that the property (if non primitive) should be serialized (as json) before saving.</param>
        public ColumnAttribute(string name = null, int order = 0, string typeName = null, bool serialize = false) : base(name)
        {
            Order = order;
            TypeName = typeName;
            Serialize = serialize;
        }
    }
}
