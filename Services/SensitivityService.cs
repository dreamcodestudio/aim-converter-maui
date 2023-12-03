using AimConverter.Models;

namespace AimConverter.Services
{
    public class SensitivityService : ISensitivityService
    {
        public float Convert(float value, GameInfo from, GameInfo to)
        {
            return value * from.Sensitivity / to.Sensitivity;
        }
    }
}