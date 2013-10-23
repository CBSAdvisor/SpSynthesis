// ***********************************************************************
// Assembly         : SpSynthesis.Domain
// Created          : 10-23-2013
//
// Last Modified On : 10-23-2013
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpSynthesis.Core.Domain;

namespace SpSynthesis.Domain
{
    /// <summary>
    /// Class Book
    /// </summary>
    public class Book : Entity<Book>
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the audio directory.
        /// </summary>
        /// <value>The audio directory.</value>
        public string AudioDirectory { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>The author.</value>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the genre.
        /// </summary>
        /// <value>The genre.</value>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>The group.</value>
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public string Comments { get; set; }


        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public byte[] Image { get; set; }

        /// <summary>
        /// Gets or sets the index of the file.
        /// </summary>
        /// <value>The index of the file.</value>
        public int FileIndex { get; set; }
    }
}
