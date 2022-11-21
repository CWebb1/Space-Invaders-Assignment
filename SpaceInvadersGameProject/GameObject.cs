using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpaceInvadersGameProject
{
    public abstract class GameObject
    {
        protected Size boundries;
        protected Graphics graphics;
        protected Point velocity;
        protected Point position;

        public Point Position { get => position; set => position = value; }

        public GameObject(Size boundries, Graphics graphics, Point velocity, Point position)
        {
            this.boundries = boundries;
            this.graphics = graphics;
            this.velocity = velocity;
            this.position = position;
        }

        public abstract void Spawn();
    }
}
