using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinth
{
    public sealed class Labyrinth
    {
        /// <summary>
        /// The cells
        /// </summary>
        private Cell[,] cells;

        /// <summary>
        /// Initializes a new instance of the <see cref="Labyrinth"/> class.
        /// </summary>
        /// <param name="cells">The cells.</param>
        public Labyrinth(Cell[,] cells, Marker marker)
        {           
            if(ReferenceEquals(cells,null))
            {
                throw new ArgumentNullException(nameof(cells));
            }

            if (ReferenceEquals(cells, marker))
            {
                throw new ArgumentNullException(nameof(marker));
            }

            this.cells = cells;
            this.Marker = marker;
            Marker.CurrentCell = cells[0, 0];
        }


        /// <summary>
        /// Gets or sets the marker.
        /// </summary>
        /// <value>
        /// The marker.
        /// </value>
        public Marker Marker { get; set; }
    }
}
