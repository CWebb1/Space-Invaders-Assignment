using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpaceInvadersGameProject
{
    public class MotherShip : GameObject
    {
        private Direction direction;

        private const int MOVEMENT = 5;

        public Direction Direction { get => direction; set => direction = value; }

        public MotherShip(Size boundries, Graphics graphics, Point velocity, Point position)
            :base(boundries,graphics,velocity,position)
        {

        }

        public override void Spawn()
        {
            //
        }

        public void MotherShipMoveLeft()
        {
            position.X -= velocity.X;
        }

        public void MotherShipMoveRight()
        {
            position.X += velocity.X;
        }
    }
}
