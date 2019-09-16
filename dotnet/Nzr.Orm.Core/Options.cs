﻿using Microsoft.Extensions.Logging;
using System.Data;

namespace Nzr.Orm.Core
{
    /// <summary>
    /// DAO options
    /// </summary>
    public class Options
    {
        /// <summary>
        /// If true, when no ColumnAttribute is defined for a property named Id, then the column name will be set as id_table.
        /// Default: true
        /// </summary>
        public bool UseComposedId { get; set; }

        /// <summary>
        /// The naming style to be used by the DAO.
        /// Default: NamingStyle.LowerCaseUnderlined
        /// </summary>
        public NamingStyle NamingStyle { get; set; }

        /// <summary>
        /// The default table schema to be used by the DAO.
        /// Default: dbo
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// The connection strings used to create connections.
        /// </summary>
        public string ConnectionStrings { get; set; }

        /// <summary>
        /// The isolation level used in the Transactions.
        /// Default: IsolationLevel.ReadCommitted
        /// </summary>
        public IsolationLevel IsolationLevel { get; internal set; }

        /// <summary>
        /// If true, will invoke the Trim method on string values returned in the DataReader.
        /// Default: true.
        /// </summary>
        public bool AutoTrimStrings { get; set; }

        /// <summary>
        /// The ILogger instance used to register log messages;
        /// </summary>
        public ILogger Logger { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Options()
        {
            Schema = "dbo";
            NamingStyle = NamingStyle.LowerCaseUnderlined;
            UseComposedId = true;
            IsolationLevel = IsolationLevel.ReadCommitted;
            AutoTrimStrings = true;
        }

        #region Builders

        /// <summary>
        /// Sets the Schema and return this instance as a builder set style.
        /// </summary>
        /// <param name="schema">The default table schema to be used by the DAO.</param>
        /// <returns>The Options instance.</returns>
        public Options WithSchema(string schema)
        {
            Schema = schema;
            return this;
        }

        #endregion
    }
}
