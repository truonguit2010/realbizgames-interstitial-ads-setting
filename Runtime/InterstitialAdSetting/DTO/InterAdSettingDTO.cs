
namespace RealbizGames.Settings
{
    public class InterAdSettingDTO
    {
        private string id;
        private bool enable;
        private float restrictSeconds;

        public string Id { get => id; set => id = value; }
        public bool Enable { get => enable; set => enable = value; }
        public float RestrictSeconds { get => restrictSeconds; set => restrictSeconds = value; }

        public override string ToString()
        {
            return ToStringUtils.ToStringFor(this);
        }
    }
}