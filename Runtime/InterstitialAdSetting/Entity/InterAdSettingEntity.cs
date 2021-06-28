

namespace RealbizGames.Settings
{
    [System.Serializable]
    public class InterAdSettingEntity
    {
        public string id;
        public int enable;
        public int restrictSeconds;
        public int reloadIntervalSeconds;

        // [Newtonsoft.Json.JsonConstructor]
        // public InterAdSettingEntity() {

        // }
    }
}