using DesignPattern.Dependency_Injection;
using DesignPattern.Abstract_Factory_Medthod;
using DesignPattern.Adapter;
using DesignPattern.Bridge;
using DesignPattern.Builder;
using DesignPattern.ChainOfResponsibility;
using DesignPattern.Command;
using DesignPattern.Composite;
using DesignPattern.Decarotor;
using DesignPattern.Facade;
using DesignPattern.Mediator;
using DesignPattern.Memento;
using DesignPattern.Observer;
using DesignPattern.Prototype;
using DesignPattern.Proxy;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Template_Method;
using DesignPattern.Visitor;
using static DesignPattern.Memento.Book;
using ProductManager = DesignPattern.Abstract_Factory_Medthod.ProductManager;
using DesignPattern.Null_Object;
using DesignPattern.Multiton;

Console.WriteLine("Hello, World!");

//Singleton();
//factoryMethod();
//AbstractFactoryMethod();
//Prototype();
//Builder();
//Facade();
//Adapter();
//CompositePattern();
//Proxy();
//Decorator();
//Bridge();
//Strategy();
// Observer();
//ChainOfResponsibility();
//Memento();
//TemplateMethod();
//State();
// Mediators();
//Commandpattern();
//VisitorPattern();
//DependencyInjection();
//NullObject();
MultitonPattern();
static void Singleton()
{
    var x = CustomerManager.CreateAsSingleton();
    x.Save();

}
static void factoryMethod()
{
    CustomerManagers customerManagers = new CustomerManagers(new LoggerFactory2());
    customerManagers.Save();
}
static void AbstractFactoryMethod()
{
    ProductManager product = new ProductManager(new Factory2());
    product.GetAll();
}
static void Prototype()
{
    Customer customer = new Customer();
    customer.FirstName = "vedat";
    customer.LastName = "arslan";
    customer.City = "istanbul";
    customer.Id = 1;
    
    Customer customer2 =(Customer) customer.Clone();
    customer2.FirstName = "Yunus";
    Console.WriteLine(customer.FirstName);
    Console.WriteLine(customer.LastName);
    Console.WriteLine(customer2.FirstName);
    Console.WriteLine(customer2.LastName);

}
static void Builder()
{
    ProductDirector director = new ProductDirector();
    var builder = new NewCustomerProductBuilder();
    director.GenerateProduct(builder);
    var model=builder.GetProductViewModel();
    Console.WriteLine(model.Id);
    Console.WriteLine(model.CategoryName);
    Console.WriteLine(model.DiscountApplied);
    Console.WriteLine(model.Discount);
    Console.WriteLine(model.ProductName);
    Console.WriteLine(model.UnitPrice);
}
static void Facade()
{
    CustomerManagerFacade customerManagerFacade = new CustomerManagerFacade();
    customerManagerFacade.Save();
} 
static void Adapter()
{
    ProductManagerAdapterExample productManagerAdapterExample = new ProductManagerAdapterExample(new Log4NetAdapter());
    productManagerAdapterExample.Save();

}
static void CompositePattern()
{
   Employees vedat = new Employees() { Name="vedat arslan"};
    Employees yunus = new Employees() { Name="yunus arslan"};
    Employees yusuf = new Employees() { Name = "yusuf arslan" };
    Employees berfin = new Employees() { Name = "berfin arslan" };
    yunus.Addpeople(vedat);
    yunus.Addpeople(berfin);
    yusuf.Addpeople(yunus);
    yusuf.Addpeople(vedat);
    yusuf.Addpeople(berfin);
    vedat.Addpeople(berfin);
    int x=0, y=0;
    foreach (Employees manager in yusuf)
    {
      ;
        Console.WriteLine(":{0}", manager.Name);
        foreach (Employees employee in manager)
        {
           
           
            Console.WriteLine("   :{0} ",employee.Name);
            foreach (var item in employee)
            {
               
                Console.WriteLine("      :{0} ", item.Name);
            }
            
        }

        
    }

}
static void Proxy()
{
    CreditManagerProxy creditManagerProxy = new CreditManagerProxy();
    Console.WriteLine(creditManagerProxy.Calculate()); 
    Console.WriteLine(creditManagerProxy.Calculate()); 
    Console.WriteLine(creditManagerProxy.Calculate()); 
    Console.WriteLine(creditManagerProxy.Calculate()); 
    Console.WriteLine(creditManagerProxy.Calculate()); 
    Console.WriteLine(creditManagerProxy.Calculate()); 
    Console.WriteLine(creditManagerProxy.Calculate()); 
   
}
static void Decorator()
{
    PersonalCar personal = new PersonalCar() { Brand = "a", HirePrice = 2500, Model = "bmw" };
    SpecialOffer carDecoratorBase = new SpecialOffer(personal);
    Console.WriteLine(carDecoratorBase.HirePrice);
    ColorCar color = new ColorCar(personal);
    Console.WriteLine(color.Model);
    
}
static void Bridge()
{
    CustomerManagerBridge customerManager = new CustomerManagerBridge();
    customerManager.message = new EmailSender();
    customerManager.UpdateCustomer();

}
static void Strategy()
{
    CustomerManagerStrategy customerManager=new CustomerManagerStrategy();
    customerManager.CreditCalculator = new After2010CreditCalculator();
    customerManager.SaveCredit();
    Console.ReadLine();
}
static void Observer()
{
    ProductManagerO productManagerO = new ProductManagerO();
    productManagerO.Attach(new CustomerObserver());
    productManagerO.Attach(new EmployeeObserver());
    productManagerO.Detach(new CustomerObserver());
    productManagerO.UpdatePrice();
    Console.ReadLine();
}
static void ChainOfResponsibility()
{
    Manager manager = new Manager();
    VicePresident vicePresident = new VicePresident();
    President president= new President();
    manager.SetSuccessor(vicePresident);
    vicePresident.SetSuccessor(president);
    Expense expense= new Expense() { Detail="training", Amount=9800};
    manager.HandleExpense(expense);
    Console.ReadLine();

}
static void Memento()
{
    Book book = new Book();
    book.SetIsbn("12345");
    book.SetTitle("portalo");
    book.SetAuthor("vedat");
    book.ShowBook();
    CareTaker history = new CareTaker();
    history.memento = book.CreateUndo();
    book.SetIsbn("54321");
    book.SetTitle("viktor huugo");
    book.SetAuthor("vedat");
    book.ShowBook();
    book.RestoreFromUndo(history.memento);
    book.ShowBook();
}
static void TemplateMethod()
{
    ScoringAlgorithm algorihtm;
    Console.WriteLine("Mans");
    algorihtm = new MensScoringAlgorithm();
    Console.WriteLine(algorihtm.GenerateScore(10,new TimeSpan(0,2,34)));
    Console.WriteLine("Womans");
    algorihtm = new WomanScoringAlgorithm();
    Console.WriteLine(algorihtm.GenerateScore(10, new TimeSpan(0, 2, 34)));
    Console.WriteLine("Childrens");
    algorihtm = new ChildrensScoringAlgorithm();
    Console.WriteLine(algorihtm.GenerateScore(10, new TimeSpan(0, 2, 34)));
}
static void State()
{
    Context context = new Context();
    ModifiedState modified = new ModifiedState();
    modified.DoAction(context);

    DeletedState deleted = new DeletedState();
    deleted.DoAction(context);

    Console.WriteLine(context.GetState().ToString());
}
static void Mediators()
{
    Mediator mediator = new Mediator();
    
    Teacher teacher = new Teacher(mediator);
    teacher.Name = "Vedat";
    mediator.Teacher=teacher;
    Student student = new Student(mediator);
   
    student.Name = "Berfin";
   
    Student student2 = new Student(mediator);
    student2.Name = "Derin";
    mediator.Students = new List<Student>() { student,student2};
    teacher.SendNewImageUrl("slide.jpg");
    teacher.RecieveQuestion("is it true?", student);
}
static void Commandpattern()
{
    
    StockManager stockManager = new StockManager(new ProductManagers(new ProductDal()));
    ByStock byStock = new ByStock(stockManager);
    SellStock sellStock = new SellStock(stockManager);
    StockController controller = new StockController();
    controller.TakeOrder(byStock);
    controller.TakeOrder(sellStock);
    controller.TakeOrder(byStock);
    controller.PlaceOrders();
}
static void VisitorPattern()
{
  Managers vedat = new DesignPattern.Visitor.Managers { Name = "vedat", Salary = 35000 };
  Managers yunus = new DesignPattern.Visitor.Managers { Name = "yunus", Salary = 12000 };
  Worker derin = new DesignPattern.Visitor.Worker { Name = "derin", Salary = 15000 };
  Worker ecrin = new DesignPattern.Visitor.Worker { Name = "ecrin", Salary = 13000 };
    vedat.Subordinates.Add(yunus);
    yunus.Subordinates.Add(derin);
    yunus.Subordinates.Add(ecrin);
    OrganisationalStructure organisationalStructure = new OrganisationalStructure(vedat);
    PayrollVisitor payrollVisitor = new PayrollVisitor();
    PayriseVisitor payrise = new PayriseVisitor();
    organisationalStructure.Accept(payrollVisitor);
    organisationalStructure.Accept(payrise);


}
static void DependencyInjection()
{
    DesignPattern.Dependency_Injection.ProductManager productManager;
    productManager=new DesignPattern.Dependency_Injection.ProductManager(new DesignPattern.Dependency_Injection.Postgres());
    productManager.Save();

}
static void NullObject()
{
    CustomerManagerNO customerManagerNO = new CustomerManagerNO(StubLogger.GetLogger());
    customerManagerNO.Save();
}
static void MultitonPattern()
{
    Camera camera = Camera.GetCamera("Nikon");
    Camera camera1 = Camera.GetCamera("Canon");
    Camera camera2 = Camera.GetCamera("Nikon");
    Camera camera3 = Camera.GetCamera("CANON");
    Console.WriteLine(camera.Id);
    Console.WriteLine(camera1.Id);
    Console.WriteLine(camera2.Id);
    Console.WriteLine(camera3.Id);
    
}