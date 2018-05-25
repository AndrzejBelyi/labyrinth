using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinth
{
    public sealed class Marker
    {       
        public Marker()
        {
        }

        /// <summary>
        /// Gets or sets the current cell.
        /// </summary>
        /// <value>
        /// The current cell.
        /// </value>
        public Cell CurrentCell { get; set; } = new Cell();

        /// <summary>
        /// Occurs when [moving succes].
        /// </summary>
        public event EventHandler<EventArgs> MovingSucces;

        /// <summary>
        /// Occurs when [moving failed].
        /// </summary>
        public event EventHandler<EventArgs> MovingFailed;

        /// <summary>
        /// Moves up.
        /// </summary>
        public void MoveUp()
        {
            if (!ReferenceEquals(CurrentCell.Top, null))
            {
                CurrentCell = CurrentCell.Top;
                OnMovingSucces(new EventArgs());
            }
            else
            {
                OnMovingFailed(new EventArgs());
            }
        }

        /// <summary>
        /// Moves the right.
        /// </summary>
        public void MoveRight()
        {
            if (!ReferenceEquals(CurrentCell.Right, null))
            {
                CurrentCell = CurrentCell.Right;
                OnMovingSucces(new EventArgs());
            }

            else
            {
                OnMovingFailed(new EventArgs());
            }
        }

        /// <summary>
        /// Moves down.
        /// </summary>
        public void MoveDown()
        {
            if (!ReferenceEquals(CurrentCell.Bottom, null))
            {
                CurrentCell = CurrentCell.Bottom;
                OnMovingSucces(new EventArgs());
            }

            else
            {
                OnMovingFailed(new EventArgs());
            }
        }

        /// <summary>
        /// Moves the left.
        /// </summary>
        public void MoveLeft()
        {
            if (!ReferenceEquals(CurrentCell.Left, null))
            {
                CurrentCell = CurrentCell.Left;
                OnMovingSucces(new EventArgs());
            }

            else
            {
                OnMovingFailed(new EventArgs());
            }
        }

        /// <summary>
        /// Raises the <see cref="E:MovingSucces" /> event.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnMovingSucces(EventArgs args)
        {
            MovingSucces.Invoke(this, args);
        }

        /// <summary>
        /// Raises the <see cref="E:MovingFailed" /> event.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnMovingFailed(EventArgs args)
        {
            MovingFailed.Invoke(this, args);
        }
    }
}
