using App.Contract;
using Zenject;

namespace App.Services
{
    public class PlayerService : IPlayerService
    {
        [Inject]
        private IPlayerController PlayerController;
        public void SendInputMessage(string input)
        {
            PlayerController.SendInputMessage(input);
        }
    }
}