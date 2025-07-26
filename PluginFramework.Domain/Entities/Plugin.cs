namespace PluginFramework.Domain.Entities;

public class Plugin
{
    public int Id { get; set; }
    public byte[] Image { get; set; } //we can use IFormFIle
    public bool Effect1 { get; set; }
    public bool Effect2 { get; set; }
    public bool Effect3 { get; set; }
    public double? Radius { get; set; }
    public double? Size { get; set; }
}
