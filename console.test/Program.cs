// See https://aka.ms/new-console-template for more information
using core.db;
using core.db.Data.Models;
using RepoDb;

Console.WriteLine("Hello, World!");
new WebUserBL().InsertOrUpdate(new WebUsers(){ id=1, CompanyCode="123", EmailID="test@gmail.com", Username="madhu",UserPassword="123" });
Console.WriteLine(TestClass.TestCall());