namespace AimConverter.Models
{
    internal class AppData
    {
        public static IReadOnlyList<GameInfo> Games = new List<GameInfo>
        {
            new() { Name = "CS:GO", Sensitivity = 44.000f, Icon = "csgo_ico.jpg" },
            new() { Name = "Valorant", Sensitivity = 140.000f, Icon = "valorant_ico.jpg" },
            new() { Name = "Fornite", Sensitivity = 11.108f, Icon = "fornite_ico.jpg" },
            new() { Name = "Apex Legends", Sensitivity = 44.000f, Icon = "apex_ico.jpg" },
            new() { Name = "Call of Duty", Sensitivity = 13.199f, Icon = "cod_ico.jpg" },
            new() { Name = "Quake Champions", Sensitivity = 44.000f, Icon = "quakechamp_ico.jpg" },
            new() { Name = "Battlefield 2042", Sensitivity = 18.127f, Icon = "bf2042_ico.jpg" },
            new() { Name = "Rainbox Six Siege", Sensitivity = 11.466f, Icon = "rainbow_six_siege_ico.jpg" },
            new() { Name = "Escape from Tarkov", Sensitivity = 250.000f, Icon = "escape_from_tarkov_ico.jpg" },
        };
    }
}