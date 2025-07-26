using Microsoft.AspNetCore.Mvc;
using PluginFramework.Application.Dtos;
using PluginFramework.Application.ServiceInterfaces;

namespace PluginFramework.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RenderController(IPluginService pluginService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Apply(PluginDto pluginDto)
    {
        if (pluginDto is null || pluginDto.Image.Length < 1)
        {
            return BadRequest();
        }

        var result = await pluginService.ApplyAsync(pluginDto);

        return Ok(result);
    }
}