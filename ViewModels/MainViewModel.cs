using AimConverter.Models;
using AimConverter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AimConverter.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public IReadOnlyList<GameInfo> Games => AppData.Games;

        [ObservableProperty] private string _targetSens = null!;

        private readonly ISensitivityService _sensitivityService;
        private float _sourceSens;
        private GameInfo? _sourceGame;
        private GameInfo? _targetGame;

        public MainViewModel(ISensitivityService sensitivityService)
        {
            _sensitivityService = sensitivityService;
        }

        [RelayCommand]
        private void OnSourceGameChanged(GameInfo gameInfo)
        {
            _sourceGame = gameInfo;
            TargetSens = _sourceGame.Name;
            Refresh();
        }

        [RelayCommand]
        private void OnTargetGameChanged(GameInfo gameInfo)
        {
            _targetGame = gameInfo;
            TargetSens = _targetGame.Name;
            Refresh();
        }

        [RelayCommand]
        private void OnSourceSensChanged(Entry entry)
        {
            entry.Unfocus();
            if (string.IsNullOrWhiteSpace(entry.Text))
                return;
            if (!float.TryParse(entry.Text, out var sourceSens))
                return;
            _sourceSens = sourceSens;
            Refresh();
        }

        private void Refresh()
        {
            if (_sourceGame == null || _targetGame == null)
                return;
            var convertedValue = _sensitivityService.Convert(_sourceSens, _sourceGame, _targetGame);
            const string sensFormat = "0.000";
            TargetSens = convertedValue.ToString(sensFormat);
        }
    }
}