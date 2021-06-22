using System.Collections.Generic;
using UnityEngine;
using ChainPattern;

namespace RealbizGames.Settings
{
    public class InterAdSettingValidation : IAsynPieceExecutor
    {
        const string TAG = "InterAdSettingValidation";

        private IInterAdSettingService service;

        public bool IsDone => _result != null;

        public IAsynPieceResult Result => _result;

        private InterAdSettingValidationResult _result;

        public InterAdSettingValidation(IInterAdSettingService service)
        {
            this.service = service;
        }

        public void Execute(IAsynChainResult data)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogFormat("{0} - Execute", TAG);
#endif

            List<InterAdSettingDTO> dtos = service.GetAll();

            // #if UNITY_EDITOR
            string msg = ToStringForList(dtos);
            UnityEngine.Debug.LogFormat("{0} - {1}", TAG, msg);
            // #endif

            _result = new InterAdSettingValidationResult(success: true);

#if UNITY_EDITOR
            UnityEngine.Debug.LogFormat("{0} - End", TAG);
#endif
        }

        public static string ToStringForList<T>(List<T> l)
        {
            string message = "Total: " + l.Count + "\n";
            foreach (T o in l)
            {
                message += o.ToString() + "\n";
            }
            return message;
        }
    }

}