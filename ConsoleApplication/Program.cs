using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Unity;
using Unity.Injection;

namespace ConsoleApplication
{
    #region AutoMapper 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        var program = new Program();
    //        Mapper.CreateMap<Customer, CustomerViewItem>()
    //            .ForMember(dest => dest.FN, opt => opt.MapFrom(src => src.FirstName));

    //        //Mapper.CreateMap<Customer, CustomerViewItem>();
    //        program.Run();
    //    }

    //    private void Run()
    //    {
    //        Customer customer = GetCustomerFromDB();

    //        CustomerViewItem customerViewItem =  Mapper.Map<Customer, CustomerViewItem>(customer);

    //        ShowCustomerInDataGrid(customerViewItem);
    //    }

    //    private void ShowCustomerInDataGrid(
    //                   CustomerViewItem customerViewItem)
    //    {
    //    }

    //    private Customer GetCustomerFromDB()
    //    {
    //        return new Customer()
    //        {
    //            DateOfBirth = new DateTime(1987, 11, 2),
    //            FirstName = "Andriy",
    //            LastName = "Buday",
    //            NumberOfOrders = 7
    //        };
    //    }
    //}

    //public class Customer
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public DateTime DateOfBirth { get; set; }

    //    public int NumberOfOrders { get; set; }
    //}

    //public class CustomerViewItem
    //{
    //    public string FN { get; set; }
    //    public string LastName { get; set; }
    //    public DateTime DateOfBirth { get; set; }

    //    public int NumberOfOrders { get; set; }
    //}

    #endregion

    #region DependencyInjection

    //UI Layer
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }
        public void Run()
        {
            //UI Layer without interfces and DI
            //Customer objCutomer = new Customer("SQLServerDB");
            //Customer objCutomer = new Customer("OracleDB");
            //objCutomer.AddCustomer();

            //UI Layer with Interface
            //Customer objCutomer = new Customer(new SQLServerDB());
            //Customer objCutomer = new Customer(new OracleDB());
            //objCutomer.AddCustomer();

            //UI Layer with DI
            IUnityContainer objContainer = new UnityContainer();
            //objContainer.RegisterType<Customer>();
            objContainer.RegisterType<IDB, OracleDB>("Oracle");
            objContainer.RegisterType<IDB,SQLServerDB>("SQLServer");

            objContainer.RegisterType<Customer>("CusOraDB",
                new InjectionConstructor(objContainer.Resolve<IDB>("Oracle")));

            objContainer.RegisterType<Customer>("CusSqlDB",
                new InjectionConstructor(objContainer.Resolve<IDB>("SQLServer")));

            var objCutomer = objContainer.Resolve<Customer>("CusOraDB");

            //var objCutomer = objContainer.Resolve<Customer>("CusSqlDB");


            objCutomer.AddCustomer();
            Console.ReadLine();
        }
    }

    //BLL Customer Class Without Interface and DI
    //class Customer
    //{
    //    public string DB = "";
    //    public Customer(string objDB)
    //    {
    //        DB = objDB;
    //    }
    //    public void AddCustomer()
    //    {
    //        // DB selection condition
    //        if (DB == "SQLServerDB")
    //        {
    //            SQLServerDB objSQLServerDB = new SQLServerDB();
    //            objSQLServerDB.Add();
    //        }
    //        else if (DB == "OracleDB")
    //        { 
    //            OracleDB objOracleDB = new OracleDB();
    //             objOracleDB.Add();
    //        }

    //    }
    //}

    //DALL Classes
    //class SQLServerDB
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Customer added in SQL Server DB");
    //    }
    //}

    //class OracleDB
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Customer added in Oracle DB");
    //    }
    //}

    //BLL Customer Class With IDB Interface
    class Customer
    {
        IDB objDatabase;
        public Customer(IDB objDB)
        {
            objDatabase = objDB;
        }
        public void AddCustomer()
        {
            objDatabase.Add();
        }
    }
    interface IDB
    {
        void Add();
    }

    //DAL Class With IDB Interface
    class SQLServerDB : IDB
    {
        public void Add()
        {
            Console.WriteLine("Customer added in SQL Server DB");
        }
    }

    class OracleDB : IDB
    {
        public void Add()
        {
            Console.WriteLine("Customer added in Oracle DB");
        }
    }
    #endregion

}
