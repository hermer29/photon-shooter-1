using Entitas;

namespace SomeMultiplayerProject.Input
{
    public class InputSystem : IInitializeSystem, IExecuteSystem
    {
        private InputEntity inputEntity;

        public void Initialize()
        {
            inputEntity = Contexts.sharedInstance.input.CreateEntity();
            inputEntity.AddLookInput(0, 0);
            inputEntity.AddMoveInput(0, 0);
        }

        public void Execute()
        {
            var horizontal = UnityEngine.Input.GetAxis("Horizontal");
            var vertical = UnityEngine.Input.GetAxis("Vertical");
            inputEntity.ReplaceMoveInput(horizontal, vertical);

            var lookY = UnityEngine.Input.GetAxis("Mouse Y");
            var lookX = UnityEngine.Input.GetAxis("Mouse X");
            inputEntity.ReplaceLookInput(lookY, lookX);
        }
    }
}