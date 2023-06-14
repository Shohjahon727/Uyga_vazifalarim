using System;
using System.Security.Cryptography.X509Certificates;

public class Kitob
{
	public string Name;
	public string Author;
	public int Pages;
	public string Genre;

	public Kitob() { }
	public Kitob (string name,string author,int pages,string genre)
	{
		Name = name;
		Author = author;
		Pages = pages;
		Genre = genre;

	}

	public void PrintInfo()
	{
        Console.WriteLine($"Name : {Name} \n" +
			$"Author : {Author}\n" +
			$"Pages : {Pages}\n" +
			$"Genre : {Genre}\n");
    }
}


