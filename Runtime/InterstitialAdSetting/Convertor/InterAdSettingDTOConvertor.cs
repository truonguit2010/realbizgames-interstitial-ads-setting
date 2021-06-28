using System.Collections.Generic;

namespace RealbizGames.Settings
{
    public class InterAdSettingDTOConvertor
    {
        public static InterAdSettingDTO From(InterAdSettingEntity entity) {
            InterAdSettingDTO dto = new InterAdSettingDTO();

            dto.Id = entity.id;
            dto.Enable = entity.enable > 0;
            dto.RestrictSeconds = entity.restrictSeconds;
            dto.ReloadIntervalSeconds = entity.reloadIntervalSeconds;

            return dto;
        }

        public static List<InterAdSettingDTO> From(List<InterAdSettingEntity> entities) {
            List<InterAdSettingDTO> dtos = new List<InterAdSettingDTO>();

            foreach(InterAdSettingEntity entity in entities) {
                dtos.Add(From(entity));
            }
            
            return dtos;
        }
    }
}