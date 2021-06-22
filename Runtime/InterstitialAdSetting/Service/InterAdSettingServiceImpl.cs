using System.Collections.Generic;

namespace RealbizGames.Settings
{
    public class InterAdSettingServiceImpl : IInterAdSettingService
    {
        InterAdSettingRepository repository = new InterAdSettingRepository("inter_ad_setting");

        public InterAdSettingDTO Get(string key)
        {
            InterAdSettingEntity entity = repository.FindById(id: key);
            InterAdSettingDTO dto = InterAdSettingDTOConvertor.From(entity);

            return dto;
        }

        public List<InterAdSettingDTO> GetAll()
        {
            List<InterAdSettingEntity> entities = repository.FindAll();
            return InterAdSettingDTOConvertor.From(entities);
        }

        public void init()
        {
            repository.init();
        }

        public void lazyInit()
        {
            repository.lazyInit();
        }

        public void refresh()
        {
            repository.refresh();
        }
    }
}