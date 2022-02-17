using MifacturaStoreApi.Models;
using MifacturaStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MifacturaStoreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MifacturasController : ControllerBase
{
    private readonly MifacturasService _mifacturasService;

    public MifacturasController(MifacturasService mifacturasService) =>
        _mifacturasService = mifacturasService;

    [HttpGet]
    public async Task<List<Mifactura>> Get() =>
        await _mifacturasService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Mifactura>> Get(string id)
    {
        var mifactura = await _mifacturasService.GetAsync(id);

        if (mifactura is null)
        {
            return NotFound();
        }

        return mifactura;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Mifactura newMifactura)
    {
        await _mifacturasService.CreateAsync(newMifactura);

        return CreatedAtAction(nameof(Get), new { id = newMifactura.Id }, newMifactura);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Mifactura updatedMifactura)
    {
        var mifactura = await _mifacturasService.GetAsync(id);

        if (mifactura is null)
        {
            return NotFound();
        }

        updatedMifactura.Id = mifactura.Id;

        await _mifacturasService.UpdateAsync(id, updatedMifactura);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var mifactura = await _mifacturasService.GetAsync(id);

        if (mifactura is null)
        {
            return NotFound();
        }

        await _mifacturasService.RemoveAsync(id);

        return NoContent();
    }
}