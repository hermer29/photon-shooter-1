using Entitas;

namespace GameplayLayer.Input.Components
{
    [Input]
    public class MoveInputComponent : IComponent
    {
        public float Horizontal;
        public float Vertical;
    }
}