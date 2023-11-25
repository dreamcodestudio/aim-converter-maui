using AimConverter.Models;

namespace AimConverter.Converters
{
    internal class SensitivityConverter
    {
        public static float Convert(float value, GameInfo from, GameInfo to)
        {
            return value * from.Sensitivity / to.Sensitivity;
        }
    }
}