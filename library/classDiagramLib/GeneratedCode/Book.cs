﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Book
{
    private long _id;
    private string _title;
    private DateTime _releaseYear;
    private int _pages;
    private string _author;

    public long Id {
        get { return _id; }
        set { _id = value; }
    }

    public string Title {
        get { return _title; }
        set { _title = value; }
    }

    public DateTime ReleaseYear {
        get { return _releaseYear; }
        set { _releaseYear = value; }
    }

    public int Pages {
        get { return _pages; }
        set { _pages = value; }
    }

    public string Author {
        get { return _author; }
        set { _author = value; }
    }
}
