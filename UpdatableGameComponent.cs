namespace PongNet.Common
{
	public abstract class UpdatableGameComponent : RenderableGameComponent
    {
        public virtual void Update(double deltaTime)
        {
            foreach (var child in this)
            {
                var childComponent = child as UpdatableGameComponent;
                if (childComponent != null)
                {
                    childComponent.Update(deltaTime);
                }
            }    
        }
    }
}
