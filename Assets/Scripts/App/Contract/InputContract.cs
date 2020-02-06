using App.Domain.MasterData;

namespace App.Contract
{
   public interface IInputModel
   {
      bool GetCanInput();
      void SetCanInput(bool can);
      void SetInputState(SceneStateMasterData state);
      SceneStateMasterData GetSceneState();
   }

   public interface IInputController
   {
      
   }

   public interface IInputService
   {
      void SetCanInput(bool state);
   }
}