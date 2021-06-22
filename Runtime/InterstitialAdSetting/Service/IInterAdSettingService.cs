using System.Collections.Generic;


namespace RealbizGames.Settings
{
    public interface IInterAdSettingService : IService
    {
        InterAdSettingDTO Get(string key);

        List<InterAdSettingDTO> GetAll();
    }

}