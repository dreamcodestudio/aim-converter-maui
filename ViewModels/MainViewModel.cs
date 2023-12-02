using AimConverter.Converters;
using AimConverter.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AimConverter.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public IReadOnlyList<GameInfo> Games => AppData.Games;
        [ObservableProperty] private string _targetSens = null!;

        [RelayCommand]
        public void OnSourceSensChanged(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return;
            if (!float.TryParse(value, out var sourceSens))
                return;
            var convertedValue = SensitivityConverter.Convert(sourceSens, Games[0], Games[1]);
            const string sensFormat = "0.000";
            TargetSens = convertedValue.ToString(sensFormat);
        }
    }
}