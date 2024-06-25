namespace EFDataBaseFirstExample;

internal class Program
{
    static void Main(string[] args)
    {
        var _context = new TqlprsdbContext(); //creating an instance of the context class
 
 //USER//////////////////////////////////////////////////////////////////
        //var newUser = new User
        //{
        //    Id = 0, Username = "km", Password = "km",
        //    Firstname = "Kaley", Lastname = "McD",
        //    //leaving out values that can be null
        //    IsReviewer = true, IsAdmin = true
        //};

        //_context.Users.Add(newUser);
        //var rowsAffected = _context.SaveChanges();

        //var deleteUser = _context.Users.Find(6);
        //_context.Users.Remove(deleteUser!);
        //var rowsAffected = _context.SaveChanges();
        //Console.WriteLine($"{rowsAffected} row(s) affected.");


 //VENDOR////////////////////////////////////////////////////////////////
        //var newVendor = new Vendor
        //{
        //    Id = 0, Code = string.Empty, 
        //    Name = "Comps Supplies Plus",
        //    Address = "8178 Goddard Drive", 
        //    City = "Columbus", State = "OH", Zip = "45230"
        //};
        //_context.Vendors.Add(newVendor);
        //var rowsAffected = _context.SaveChanges();
        //Console.Write($"{rowsAffected} vendor(s) added.");

 //PRODUCT/////////////////////////////////////////////////////////////////////

        //var newProduct = new Product
        //{
        //    Id = 0,
        //    PartNbr = "45613581686",
        //    Name = "Charging Adaptor",
        //    Price = 8.99m,
        //    Unit = "USD",
        //    VendorId = 4
        //};
        //_context.Products.Add(newProduct);
        //var rowsAffected = _context.SaveChanges();
        //Console.Write($"{rowsAffected} products(s) added.");

 //REQUEST/////////////////////////////////////////////////////////////////////
        //var newRequest = new Request
        //{
        //    Id = 0, Description = "request for more Iphones & new product (charging adaptor).",
        //    Justification = "low stock and new product fufillment",
        //    DeliveryMode = "pickup",
        //    Status = "NEW", Total = 22000.0m, 
        //    UserId = 3
        //};
        //_context.Requests.Add(newRequest);
        //var rowsAffected = _context.SaveChanges();
        //Console.Write($"{rowsAffected} request(s) added.");    
    
 //REQUEST LINES/////////////////////////////////////////////////////////////
        //var newRL = new Requestline
        //{
        //    Id = 0, RequestId= 2, ProductId = 9,
        //    Quantity = 30
        //};


        //var newRL2 = new Requestline
        //{
        //    Id = 0, RequestId= 2, ProductId = 10,
        //    Quantity = 30
        //};

        //_context.Requestlines.Add(newRL2);
       // _context.SaveChanges();

//REMOVE///////////////////////////////////////////////////////////////////
    
        var removeProduct = _context.Products.Find(17);
        {
            _context.Products.Remove(removeProduct!);
            _context.SaveChanges();
        };
    }
    }
     
   
  
        
      
        
        

        
        
       
        
        
        
