using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WypozyczalniaRowerow.Models;
using WypozyczalniaRowerow.Services.VehicleService;

namespace WypozyczalniaRowerow.Controllers;

public class VehicleController : Controller
{
    private readonly IMapper _mapper;
    private readonly IVehicleService _service;

    public VehicleController(IVehicleService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult List()
    {
        var vehicles = _service.GetAll().ToList();
        return View(_mapper.Map<List<Vehicle>>(vehicles));
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Vehicle vehicle)
    {
        if (ModelState.IsValid)
        {
            _service.Add(_mapper.Map<Vehicle>(vehicle));
            _service.Save();
            return RedirectToAction(nameof(List));
        }

        return View();
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var vehicle = _service.GetById(id);
        return View(_mapper.Map<Vehicle>(vehicle));
    }

    [HttpPost]
    public IActionResult Delete(Vehicle vehicle)
    {
        _service.Delete(_mapper.Map<Vehicle>(vehicle));
        _service.Save();
        return RedirectToAction(nameof(List));
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        var vehicle = _service.GetById(id);
        return View(_mapper.Map<Vehicle>(vehicle));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var vehicle = _service.GetById(id);
        return View(_mapper.Map<Vehicle>(vehicle));
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Vehicle vehicle)
    {
        if (ModelState.IsValid)
        {
            _service.Edit(_mapper.Map<Vehicle>(vehicle));
            _service.Save();
            return RedirectToAction(nameof(List));
        }

        return View();
    }
}