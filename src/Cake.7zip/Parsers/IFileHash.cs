using System.Collections.Generic;

using Cake.SevenZip.Commands;

namespace Cake.SevenZip.Parsers
{
    /// <summary>
    /// The information of one file, as generated by the <see cref="HashCommand"/>.
    /// <para>
    /// Used in the <see cref="IHashOutput"/>.
    /// </para>
    /// </summary>
    public interface IFileHash
    {
        /// <summary>
        /// Gets the hash. Content depends on the selected hash-algorithm.
        /// </summary>
        /// <value>
        /// The hash.
        /// </value>
        IEnumerable<IHash> Hashes { get; }

        /// <summary>
        /// Gets the path of the file.
        /// </summary>
        /// <value>
        /// The path of the file.
        /// </value>
        string FilePath { get; }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        long Size { get; }
    }
}