using ChainPattern;

namespace RealbizGames.Settings
{
    public class InterAdSettingValidationResult : IAsynPieceResult
    {
        public const string PUBLIC_KEY = "InterAdSettingValidationResult";

        private bool _success;

        public InterAdSettingValidationResult(bool success)
        {
            _success = success;
        }

        public bool Success { get => _success; set => _success = value; }

        public string GetKey()
        {
            return PUBLIC_KEY;
        }
    }
}