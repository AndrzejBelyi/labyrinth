using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinth
{
    public sealed class MoveEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the report.
        /// </summary>
        /// <value>
        /// The report.
        /// </value>
        public Tuple<int,int> Coordinates { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimerTickEvenArgs"/> class.
        /// </summary>
        /// <param name="report">The report.</param>
        public MoveEventArgs(int i,int j)
        {
            Coordinates = new Tuple<int, int>(i,j);
        }
    }
}
