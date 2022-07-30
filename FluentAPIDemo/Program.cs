// See https://aka.ms/new-console-template for more information
using FluentAPIDemo.Models;



BookStoreDbContext _dbContext = new BookStoreDbContext();
Console.WriteLine("Printing the Supplier Details");
GetSuppliers();
Console.WriteLine("Give the Supplier Id");
string supplierId = Console.ReadLine();

DeleteSupplier(supplierId);
//Console.WriteLine("Enter Supplier address");
//string address = Console.ReadLine();
//UpdateSupplier(supplierId, address);
Console.WriteLine("---------------------------------------------------");
GetSuppliers();


//GetSupplierById(supplierId);
//Console.WriteLine("Give the Supplier Name");
//string supplierName= Console.ReadLine();
//GetSupplierByName(supplierName);

void DeleteSupplier(string supplierId)
{
    _dbContext = new BookStoreDbContext();
    var supplier = _dbContext.Suppliers.Find(supplierId);// finding the row for delete
                                                         //   _dbContext.Suppliers.Remove(supplier); // deleting the row --hard delete 
    supplier.IsActive = 0;// soft delete

    _dbContext.SaveChanges(); // saving the changes


}


void UpdateSupplier(string supplierId, string address)
{
    _dbContext = new BookStoreDbContext();
    var supplier = _dbContext.Suppliers.Find(supplierId);// finding the row for update 
    supplier.Address = address;// update the coulmn
    _dbContext.SaveChanges();// save changes 
}

void GetSuppliers()
{
    _dbContext = new BookStoreDbContext();
    List<Supplier> suppliers = _dbContext.Suppliers.ToList();
    foreach (Supplier item in suppliers)
    {
        Console.WriteLine(item.SupplierId+"  "+item.SupplierName+" "+item.Email+"  "+item.Address);
    }

}
Supplier supplierObject;

void GetSupplierById(string supplierId)
{
    _dbContext = new BookStoreDbContext();
  supplierObject  = _dbContext.Suppliers.Find(supplierId);// Find method will automatically maps the parameter to the primary key coulmn of the table.
    Console.WriteLine(supplierObject.SupplierName+"  "+supplierObject.Email);

}

void GetSupplierByName(string supplierName)
{
    _dbContext = new BookStoreDbContext();
    List<Supplier> suppliers = _dbContext.Suppliers.Where(r => r.SupplierName .Contains(supplierName)).ToList();
    foreach (Supplier item in suppliers)
    {
        Console.WriteLine(item.SupplierId + "  " + item.SupplierName + " " + item.Email + "  " + item.Address);
    }
}
