using Microsoft.SqlServer.Server;
using onlineMovieTicketBooking;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
   public  class Program
    {
        //MovieList ml = new MovieList();
        //CustomerList cl = new CustomerList();
        //AdminList al = new AdminList();
        //TicketList tl = new TicketList();
        CustomerCrud cc = new CustomerCrud();
        AdminCrud ac = new AdminCrud();
        MovieCrud mc = new MovieCrud();
        TicketCrud tc = new TicketCrud();
        private void mainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("welcome to onlineticketbooking");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("............");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.login as admin");
            Console.WriteLine("2.login as customer");
            Console.WriteLine("3.Singup as Customer");
            Console.WriteLine("4.Singup as Admin");
            Console.WriteLine("5.exit");
            Console.ResetColor();
            mainMenuDetails();
        }
        private void mainMenuDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("enter your choice...");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int i = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (i)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    AdminLogin();
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    CustomerLogin();
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    SignUpCustomer();
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    SignUpAdmin();
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Environment.Exit(0);
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("choose either 1 or 2 or 3");
                    Console.ResetColor();
                    break;
            }
        }
        private void adminMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.update movies");
            Console.WriteLine("2.view customer profile");
            Console.WriteLine("3.view booking History");
            Console.WriteLine("4.exit");
            Console.WriteLine("enter your choice");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            int j = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (j)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    updateMovies();
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    viewCustomerprofile();
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    viewBookinghistory();
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Environment.Exit(0);
                    Console.ResetColor();
                    break;     
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("choose either 1 or 2 or 3");
                    Console.ResetColor();
                    break;
            }
            Console.WriteLine("New line -> \n");
            adminMenu();
        }
        private void customerMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.view profile");
            Console.WriteLine("2.booking a ticket");
            Console.WriteLine("3.view movies");
            Console.WriteLine("4.view history");
            Console.WriteLine("5.Cancel a ticket");
            Console.WriteLine("6.exit");
            Console.WriteLine("enter your choice");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            int j = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (j)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    viewProfile();
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    bookTicket();
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    mc.ReadData();
                    exit1();
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    viewHistory();
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    cancleTicket();
                    Console.ResetColor();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Environment.Exit(0);
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("choose either 1 or 2 or 3 or 4");
                    Console.ResetColor();
                    break;
            }
            Console.WriteLine("New line -> \n");
            customerMenu();
        }
        private void viewProfile()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("enter the customer id");
            Console.ResetColor();
            int id = Convert.ToInt32(Console.ReadLine());
            //Customer e =  cl.CustomerDetails(id);
            Boolean customer = cc.CustomerData(id);
            if(!customer)
            {
                Console.WriteLine("No Data found");
            }
            //Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Id = {0}, Name = {1}, Password = {2}, Walletamt = {3}, Phoneno = {4}, Location = {5}", e.CustomerId, e.CustomerName, e.Password, e.WalletAmt, e.PhoneNo, e.Address);
            //    Console.ResetColor();
            exit1();
        }

        private void bookTicket()
        {
            // viewMovies();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("please enter the customerId");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int cId = Convert.ToInt32(Console.ReadLine());
           // Customer c = cl.CustomerDetails(cId);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("please enter the MovieId");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            int MId = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
           // Movie m = ml.MovieDetails(MId);
            Console.ForegroundColor = ConsoleColor.Red;
            int at = Convert.ToInt32(mc.RetriveData(MId));
            Console.WriteLine("Available Tickets : " + at);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("please enter the Number of tickets ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            int not = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            double amount = Totalamount(not);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("please enter the Seat number ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            int sn = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("please enter Yes to Confirm ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            string con = Console.ReadLine();
            Console.ResetColor();
            int tid = tc.Count() + 1;
            if (con == "Yes" || con == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Thanks your ticket have been confirmed");
                Console.ResetColor();
                String mname =Convert.ToString( mc.RetriveMovieName(MId));
                DateTime mtime = Convert.ToDateTime(mc.showTimings(MId));
                Ticket t1 = new Ticket(tid,mname, mtime, cId, not, amount, sn);
                // tl.NewTicket(t1);
                tc.CreateData(t1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Id = {0}, MovieName = {1}, Timings = {2}, customerId = {3}, Number of Tickets = {4},AAmount = {5}, Seat Number {6}", 1, mname, mtime, cId, not, amount, sn);
                Console.ResetColor();
                 at = at - not;
                mc.UpdateData(at, MId);
                double amt = Convert.ToInt32(cc.RetriveData(cId));
                 amt = amt - amount;
                cc.UpdateData(amt, cId);
                 Console.ForegroundColor = ConsoleColor.Blue;
                 Console.WriteLine("Your Wallet balance is : " + amt);
                Console.ResetColor();
                exit1();
            }

            else
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please try again");
            Console.ResetColor();

            exit1();

        }
      //  private void viewMovies()
       // {
          //  ml.MovieView();
           // exit1();
       // }
        private void viewHistory()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("please enter the customerId");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int cId = Convert.ToInt32(Console.ReadLine());
            // Ticket t1 = tl.CustomerHistory(cId);
            tc.CustomerHistory(cId);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Id = {0}, MovieName = {1}, Timings = {2}, customerId = {3}, Number of Tickets = {4},AAmount = {5}, Seat Number {6}", t1.TicketId, t1.MovieName, t1.Showtime, t1.CustomerId, t1.Not, t1.Amount, t1.SeatNumber);
            //Console.ResetColor();
            exit1();

        }
        private void cancleTicket()
        {
            Console.WriteLine("please enter the ticket Id ");
            int tid = Convert.ToInt32(Console.ReadLine());
            // Ticket t1 = tl.TicketCancellation(tid);
            tc.RetriveData(tid);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Id = {0}, MovieName = {1}, Timings = {2}, customerId = {3}, Number of Tickets = {4},AAmount = {5}, Seat Number {6}", t1.TicketId, t1.MovieName, t1.Showtime, t1.CustomerId, t1.Not, t1.Amount, t1.SeatNumber);
            //Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("please enter yes to continue");
            string con = Console.ReadLine();
            if (con == "Yes" || con == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("your ticket had been cancelled successfully");
                Console.ResetColor();
                exit1();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("your ticket has not Cancelled please try again");
                Console.ResetColor();
                exit1();
            }
        }

        private void updateMovies()

        {
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("enter the movie Id");
            //Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            int mn = mc.Count()+1;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the movie name");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the timings");
            //DateTime currentDateTime = DateTime.Now;
            DateTime currentDateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the movie location");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            string location = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the movie language");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string language = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("enter the Screen number");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            int sn = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("enter the Available Tickets");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            int at = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Movie m2 = new Movie(mn, name, currentDateTime, location, language, sn, at);
            // ml.MovieUpdate(m2);
            mc.CreateData(m2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("/n Updated details");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Id = {0}, Name = {1}, Timings = {2}, Location = {3}, Language = {4}, ScreenNo = {5}, AvailableTickets {6}", m2.MovieId, m2.MovieName, m2.ShowTimings, m2.Location, m2.Language, m2.ScreenNo, m2.AvailableTickets);
            Console.ResetColor();
            exit();
        }

        private void viewCustomerprofile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("enter the customer id");
            Console.ResetColor();
            int id = Convert.ToInt32(Console.ReadLine());
            //Customer e = cl.CustomerDetails(id);
            //     Console.ForegroundColor = ConsoleColor.Cyan;
            //     Console.WriteLine("Id = {0}, Name = {1}, Password = {2}, Walletamt = {3}, Phoneno = {4}, Location = {5}", e.CustomerId, e.CustomerName, e.Password, e.WalletAmt, e.PhoneNo, e.Address);
            //     Console.ResetColor();
            cc.CustomerData(id);
            exit();
        }

        private void viewBookinghistory()
        {
            // tl.BookingHistory();
            tc.ReadData();
            exit();
        }

        private void exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1.Admin Menu");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2.Main Menu");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("enter your choice");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            int k = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (k)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    adminMenu();
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    mainMenu();
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Choose 1 or 2");
                    Console.ResetColor();
                    break;
            }
        }

        public void exit1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1.Customer Menu");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2.Main Menu");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("enter your choice");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            int k = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (k)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    customerMenu();
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    mainMenu();
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Choose 1 or 2");
                    Console.ResetColor();
                    break;
            }

        }
        public double Totalamount(int not)
        {
            double amount = not * 100;
            return amount;

        }
        public void AdminLogin()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your PhoneNumber");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            long phno = Convert.ToInt64(Console.ReadLine());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your Password");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            string pwd = Console.ReadLine();
            Console.ResetColor();
            // bool flag = al.ALoginCheck(phno,pwd);
            Boolean flag = ac.LoginCheck(phno, pwd);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Thanks for logging");
                Console.ResetColor();
                adminMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Credentials");
                Console.ResetColor();
                mainMenu();
            }
        }
        public void CustomerLogin()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your PhoneNumber");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            long phno = Convert.ToInt64(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your Password");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            string pwd = Console.ReadLine();
            Console.ResetColor();
            // bool flag = cl.LoginCheck(phno, pwd);
            Boolean flag = cc.LoginCheck(phno, pwd);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Thanks for logging");
                Console.ResetColor();
                customerMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Credentials");
                Console.ResetColor();
                mainMenu();
            }
        }
        public void SignUpCustomer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int CId = cc.Count()+1;
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string pwd = Console.ReadLine();
            Console.WriteLine("Your Wallet amount is : 1000");
            double amount = 1000;
            Console.WriteLine("Please enter your phone number");
            long phno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter your address");
            string add = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Id = {0}, Name = {1}, Password = {2}, Walletamt = {3}, Phoneno = {4}, Location = {5}", CId, name, pwd, amount, phno, add);
            Console.WriteLine("Please check your details and enter Yes to continue ");
            string con = Console.ReadLine();
            Console.ResetColor();
            if (con == "Yes" || con == "yes")
            {
                Customer ca = new Customer(CId, name, pwd, amount, phno, add);
              //  cl.NewCustomer(ca);
                cc.CreateData(ca);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your are singedup successfully");
                Console.WriteLine("please login to continue");
                Console.ResetColor();
                CustomerLogin();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please try again");
                Console.ResetColor();
                mainMenu();
            }

        }
        public void SignUpAdmin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int AId = ac.Count()+1;
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string pwd = Console.ReadLine();
            Console.WriteLine("Your Wallet amount is : 1000");
            double amount = 1000;
            Console.WriteLine("Please enter your phone number");
            long phno = Convert.ToInt64(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Id = {0}, Name = {1}, Password = {2}, Walletamt = {3}, Phoneno = {4}", AId, name, pwd, amount, phno);
            Console.WriteLine("Please check your details and enter Yes to continue ");
            string con = Console.ReadLine();
            Console.ResetColor();
            if (con == "Yes" || con == "yes")
            {
                Admin aa = new Admin(AId, name, pwd, amount, phno);
                // al.NewAdmin(aa);
                ac.CreateData(aa);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your are singedup successfully");
                Console.WriteLine("please login to continue");
                Console.ResetColor();
                AdminLogin();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please try again");
                Console.ResetColor();
                mainMenu();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.mainMenu();
        }

    }
}