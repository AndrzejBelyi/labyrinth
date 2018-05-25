using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinth
{
    public sealed class MoveService
    {
        /// <summary>
        /// Gets the labyrinth.
        /// </summary>
        /// <value>
        /// The labyrinth.
        /// </value>
        private Labyrinth labyrinth { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveService"/> class.
        /// </summary>
        /// <param name="lab">The lab.</param>
        public MoveService(Labyrinth lab)
        {
            this.labyrinth = lab;
            lab.Marker.MovingSucces += (sender,args) => Console.WriteLine("Движение успешно!");
            lab.Marker.MovingFailed += (sender, args) => Console.WriteLine("Нетуды!");

        }

        /// <summary>
        /// Moves up.
        /// </summary>
        public void MoveUp()
        {
            labyrinth.Marker.MoveUp();  
        }

        /// <summary>
        /// Moves the right.
        /// </summary>
        public void MoveRight()
        {
            labyrinth.Marker.MoveRight();
        }

        /// <summary>
        /// Moves down.
        /// </summary>
        public void MoveDown()
        {
            labyrinth.Marker.MoveDown();
        }

        /// <summary>
        /// Moves the left.
        /// </summary>
        public void MoveLeft()
        {
            labyrinth.Marker.MoveLeft();
        }

    }
}
