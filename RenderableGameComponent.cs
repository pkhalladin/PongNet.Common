﻿using System.Collections;
using System.Drawing;

namespace PongNet.Common
{
    public abstract class RenderableGameComponent : IEnumerable<RenderableGameComponent>
    {
        private RenderableGameComponent parent;
        private IList<RenderableGameComponent> children;
        protected bool isVisible;

        public RenderableGameComponent()
        {
            children = new List<RenderableGameComponent>();
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
		public virtual bool IsVisible { get => isVisible; set => isVisible = value; }
		public Rectangle Bounds => new Rectangle(X, Y, Width, Height);
        public virtual RenderableGameComponent Parent => parent;
        public virtual IList<RenderableGameComponent> Children => children;

        public virtual void Render(Graphics g)
        {
			foreach (var child in this)
			{
                if (child.IsVisible)
                {
                    child.Render(g);
                }
			}
		}

        public void AddChild(RenderableGameComponent child)
        {
            child.parent = this;
            children.Add(child);
        }

        public void Add(RenderableGameComponent child)
        {
            AddChild(child);
        }

        public IEnumerator<RenderableGameComponent> GetEnumerator()
        {
            return children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
