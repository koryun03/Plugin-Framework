using PluginFramework.Application.Dtos;

namespace PluginFramework.Application.ServiceInterfaces;

public interface IPluginService
{
    public Task<byte[]> ApplyAsync(PluginDto pluginDto);
}