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

public interface IBookManager 
{
	void CreateBook(Book book);

	Book GetBookById(long id);

	List<Book> FindAllBooks();

	void UpdateBook(Book book);

	void DeleteBook(Book book);

	List<Book> FindBooksByAuthor(string author);

	List<Book> FindBooksByTitle(string title);

}

