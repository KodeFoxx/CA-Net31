using System.Diagnostics;

namespace Kf.CANetCore31.Diagnostics
{
    /// <summary>
    /// Interface to facilitate implementing the <see cref="DebuggerDisplayAttribute"/>.
    /// </summary>
    /// <example>
    /// Place the attribute on your class as shown below.
    /// <code>
    /// [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    /// </code>
    /// </example>
    public interface IDebuggerDisplayString
    {
        /// <summary>
        /// The string intended to be used in the <see cref="DebuggerDisplayAttribute"/>.
        /// </summary>
        /// <example>
        /// Place the attribute on your class as shown below.
        /// <code>
        /// [DebuggerDisplay("{DebuggerDisplayString,nq}")]
        /// </code>
        /// </example>
        string DebuggerDisplayString { get; }
    }
}
