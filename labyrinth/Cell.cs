using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinth
{
    public class Cell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cell"/> class.
        /// </summary>
        public Cell()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell"/> class.
        /// </summary>
        /// <param name="top">The top.</param>
        /// <param name="right">The right.</param>
        /// <param name="bottom">The bottom.</param>
        /// <param name="left">The left.</param>
        /// <exception cref="ArgumentException"></exception>
        public Cell(Cell top,Cell right,Cell bottom,Cell left)
        {
            if(top == null && right == null && bottom == null && left == null)
            {
                throw new ArgumentException();
            }

            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Left = left;
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Cell"/> is top.
        /// </summary>
        /// <value>
        ///   <c>true</c> if top; otherwise, <c>false</c>.
        /// </value>
        public Cell Top { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Cell"/> is right.
        /// </summary>
        /// <value>
        ///   <c>true</c> if right; otherwise, <c>false</c>.
        /// </value>
        public Cell Right { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Cell"/> is bottom.
        /// </summary>
        /// <value>
        ///   <c>true</c> if bottom; otherwise, <c>false</c>.
        /// </value>
        public Cell Bottom { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Cell"/> is left.
        /// </summary>
        /// <value>
        ///   <c>true</c> if left; otherwise, <c>false</c>.
        /// </value>
        public Cell Left { get; set; }
    }
}
