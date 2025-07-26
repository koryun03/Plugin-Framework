using PluginFramework.Application.Dtos;
using PluginFramework.Application.ServiceInterfaces;
using PluginFramework.Domain.Entities;

namespace PluginFramework.Application.Services;

public class PluginService : IPluginService
{
    public async Task<byte[]> ApplyAsync(PluginDto pluginDto)
    {
        var plugin = new Plugin
        {
            Id = pluginDto.Id,
            Image = pluginDto.Image,
            Effect1 = pluginDto.Effect1,
            Effect2 = pluginDto.Effect2,
            Effect3 = pluginDto.Effect3,
            Radius = pluginDto.Radius,
            Size = pluginDto.Size,
        };

        //These methods are for picture rendering.
        //We can create a new service for rendering or use static methods.

        //if (plugin.Effect1)
        //    plugin.Image = await ApplyEffect1Async(plugin.Image);

        //if (plugin.Effect2)
        //    plugin.Image = await ApplyEffect2Async(plugin.Image);

        //if (plugin.Effect3)
        //    plugin.Image = await ApplyEffect3Async(plugin.Image);

        //if (plugin.Radius > 1)
        //    plugin.Image = await ApplyRadiusEffectAsync(plugin.Image, plugin.Radius);

        //if (plugin.Size > 1)
        //    plugin.Image = await ApplyResizeAsync(plugin.Image, plugin.Size);

        return plugin.Image;
    }
}