using AimConverter.Models;

namespace AimConverter.Services
{
    public interface ISensitivityService
    {
        float Convert(float value, GameInfo from, GameInfo to);
    }
}