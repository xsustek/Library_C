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

public interface ICustomerManager 
{
	void CreateCustomer(Customer customer);

	Customer GetCustomerById(long id);

	List<Customer> FindAllCustomer();

	void UpdateCustomer(Customer customer);

	void DeteleCustomer(Customer customer);

}
