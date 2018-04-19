using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;
using System;

namespace CdOrganizer.Models
{
  public class Cd
  {
    private string _title;
    private int _id;
    private static List<Cd> _cds = new List<Cd>{};

    public Cd(string title)
    {
      _title = title;
      _cds.Add(this);
      _id = _cds.Count;
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Cd> GetAll()
    {
      return _cds;
    }
    public static void ClearAll()
    {
      _cds.Clear();
    }
    public static Cd Find (int searchId)
    {
      return _cds[searchId-1];
    }
  }
}
