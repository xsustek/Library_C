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

public class Lease
{
    private DateTime _realEndTime;
    private DateTime _endTime;
    private Customer _customer;
    private Book _book;
    private long _id;

    public long Id {
        get { return _id; }
        set { _id = value; }
    }

    public Book Book {
        get { return _book; }
        set { _book = value; }
    }

    public Customer Customer {
        get { return _customer; }
        set { _customer = value; }
    }

    public DateTime EndTime {
        get { return _endTime; }
        set { _endTime = value; }
    }

    public DateTime RealEndTime {
        get { return _realEndTime; }
        set { _realEndTime = value; }
    }
}
