using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;
using System;

namespace CdOrganizer.Controllers
{
  public class CdsController : Controller
  {
    [HttpGet("/cds")]
    public ActionResult Index()
    {
      List<Cd>allCds = Cd.GetAll();
      return View(allCds);
    }

    [HttpGet("/cds/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cds")]
    public ActionResult Create()
    {
      Cd newCd = new Cd(Request.Form["new-cd"]);
      List<Cd> allCds = Cd.GetAll();
      return View("Index", allCds);
    }

    [HttpGet("/cds/{id}")]
    public ActionResult Details (int id)
    {
      Cd cd = Cd.Find(id);
      return View(cd);
    }

    [HttpPost("/cds/delete")]
       public ActionResult DeleteAll()
       {
           Cd.ClearAll();
           return View();
       }
  }
}
