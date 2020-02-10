using System;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef
{
    /// <summary>
    /// SQL Server Data Types
    /// If anything is missing, add from this list https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
    /// </summary>
    public static class SqlServerColumnTypes
    {
        /// <summary>
        /// <see cref="Int16"/>.
        /// </summary>
        public static string Int16_SMALLINT => "SMALLINT";

        /// <summary>
        /// <see cref="Int32"/>.
        /// </summary>
        public static string Int32_INT => "INT";

        /// <summary>
        /// <see cref="Int64"/>.
        /// </summary>
        public static string Int64_BIGINT => "BIGINT";

        /// <summary>
        /// <see cref="Boolean"/>.
        /// </summary>
        public static string Boolean_BIT => "BIT";

        /// <summary>
        /// <see cref="String"/>.
        /// </summary>
        public static string String_CHAR => "CHAR";

        /// <summary>
        /// <see cref="String"/>.
        /// </summary>
        public static string String_NVARCHAR => "NVARCHAR";

        /// <summary>
        /// <see cref="TimeSpan"/>.
        /// </summary>
        public static string TimeSpan_TIME => "TIME";

        /// <summary>
        /// <see cref="Byte"/>[].
        /// </summary>
        public static string ArrayOfByte_TIMESTAMP => "TIMESTAMP";

        /// <summary>
        /// <see cref="DateTime"/>.
        /// </summary>
        public static string DateTime_DATE => "DATE";

        /// <summary>
        /// <see cref="DateTime"/>.
        /// </summary>
        public static string DateTime_DATETIME => "DATETIME";

        /// <summary>
        /// <see cref="DateTime"/>.
        /// </summary>
        public static string DateTime_DATETIME2 => "DATETIME2";

        /// <summary>
        /// <see cref="DateTimeOffset"/>.
        /// </summary>
        public static string DateTime_DATETIMEOFFSET => "DATETIMEOFFSET";
    }
}
