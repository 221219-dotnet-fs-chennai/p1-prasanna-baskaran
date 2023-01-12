using System;


class Zexchange 
  {
  int earnings;
  }
  
class Employee 
  {
    string Fullname;
    string Emailid;
    string mobileno;
    string Password;
    int conv= 2;
    Employee (string Fullname, string Emailid,string mobileno, string pass){
    this.Fullname=Fullname;
    this.Emailid=Emailid;
    this.mobileno=mobileno;
    this.Password=pass;
    }
  }
class Customer 
  {
    string Fullname;
    string Emailid;
    string mobileno;
    string Hid;  
    string Password;
    static string [] Trhistory= new string[1000];
    int Rc;
    int zc;
    string ZID=null;
    Customer(string Fullname, string Emailid,string mobileno, string Hid, string pass, int Rc, string Trhistory)
    {
    this.Fullname=Fullname;
    this.Emailid=Emailid;
    this.mobileno=mobileno;
    this.Hid=Hid;
    this.Password=pass;
    this.Rc=Rc;
    Customer.Trhistory[0]=Trhistory;
      this.zc=20;
    }
    bool approve(Customer c,bool x)
    {
      if (x==true)
      {
        c.ZID =(string)(Math.()*10);
        return true;
      } 
      else 
        c.ZID=null;
      return false;
    }
    
  
 static Customer Register(string Name, string Emailid, string Mobileno,string H_Id, string pas,int Amount,string history)
  {
  Customer a =new Customer(Name, Emailid, Mobileno,H_Id, pas, Amount,Trhistory[0]);
    return a;
  }



 public class Zexchange{
    public static void main (string[]args){
        Scanner sc=new Scanner(System.in);
//--------------------------------------
      string s="";
           Customer cus=new Customer("Prasanna","cus1@gmail.com","6382219105","1234 5678 9012","test123",1000,s);
           Customer cus2=new Customer("Surendar","cus2@gmail.com","6382219106","1234 5678 9012","test123",1000,s); 
      Customer.Trhistory[0]= "1-1-1111  debit 10  .03  1000";
      Customer.Trhistory[0]=" 1-1-1111  debit 10  .03  1000";
      cus.ZID = "1";
     cus2.ZID = "2";
  //---------------------------------------------   
     // List <Customer> a;
      ArrayList<Customer> x = new ArrayList<Customer>();
       x.add(cus);
      x.add(cus2);
//-------------------------------------
       Employee emp=new Employee("employee1","admin@ze.com","1234567891","test123");
//-------------------------------------------
      bool choice=true;
             while(choice)
             {
          Console.WriteLine("__________Z-Coin Management___________");
          Console.WriteLine("1.Customer login");
          Console.WriteLine("2.Employee login");
          Console.WriteLine("3.Exit");
          Console.WriteLine("Enter ur choice:1|2|3");
            string o1= sc.nextLine();
            int choice1 =Convert.ToInt32(o1);
             switch(choice1)
                 {
                     case 1: 
                           Console.WriteLine("__________Z-Coin Management( Customer portal )___________");
                           Console.WriteLine("1.New Customer Registeration");
                           Console.WriteLine("2.Existing user login");
                           Console.WriteLine("4.Back to home");
                           Console.WriteLine("Enter ur choice:");
                             string o= sc.nextLine(); 
                             int option = Convert.Int32(o);
                             switch(option)
                                     {
                                        case 1:
                                              Console.WriteLine("__________Z-Coin Management( New customer registration  )___________");
                                              Console.WriteLine("Enter your name");
                                                string Name=sc.nextLine();
                                              Console.WriteLine("Enter E-maiId");
                                                string Emailid=sc.nextLine();
                                              Console.WriteLine("Enter Mobile No");
                                                string Mobileno=sc.nextLine(); 
                                              Console.WriteLine("Enter Gov-Id");
                                                string H_Id=sc.nextLine(); 
                                                Boolean flag=false;
                                                 string pas="";
                                                 string trhistory=null;
                                                 
                                                while(!flag)
                                                {
                                              Console.WriteLine("Enter Valid login password");
                                                pas=sc.nextLine();
                                                flag=isvalidPass(pas);
                                                }
                                              Console.WriteLine("Enter Intial amount");
                                                string o2= sc.nextLine();
                                                 int Amount = Integer.parseInt(o2);                                                                           if(flag == true)
                                                  {
                                                	 Customer cus3=new Customer(Name,Emailid,Mobileno, H_Id,pas,Amount,trhistory);
                                                     x.add(cus3);                                                             
                                                	 System.out.println("New User Register Succesfully");    
                                                  }
                                                 
                                        case 2:
                                               Console.WriteLine("__________Z-Coin Management( Existing customer Login )___________");
                                               Console.WriteLine("Enter valid customer email Id");
                                                 string EmailId1=sc.nextLine();
                                               Console.WriteLine("Enter correct password");
                                                 string password =sc.nextLine();
                                               Console.WriteLine("Validating Credintials....");
                                         int n=x.size(); 
                                         int c=-1;
                                         for(int cus_tot=0;cus_tot<n;cus_tot++)
                                           {
                                            if ( (x.get(cus_tot).Emailid).equals(EmailId1) )
                                             {
                                               if(password.equals(x.get(cus_tot).Password))
                                                  {
                                                    if  (x.get(cus_tot).ZID!=null)                                                                                                 {
                                                    Console.WriteLine(" Customer login successful");
                                                          c=cus_tot;
                                                            }                                                                                                                else
                                                    Console.WriteLine("Account yet to be approved");
                                                  }
                                             
                                             }
                                           }
                                         if(c!=-1)
                                         {
                                           Customer m = x.get(c);
                                         Console.WriteLine("__________Z-Coin  Customer :-"+m.Fullname+ "'s Account Management Portal_____________");
                                         Console.WriteLine("Enter you options \n 1).Account details \n 2).Transaction history  \n 3).Change password \n 4).RC transactions \n 5)Zcoin transactions 6) Press 0 to exit");
                                           string o4= sc.nextLine();
                                           int option4 = Integer.parseInt(o4);
                                          while(option4>0)
                                              {
                                                
                                                if(option4==1)
                                                {
                                                Console.WriteLine("\n\tFull name:\t"+m.Fullname+"\n\tEmailid:\t"+m.Emailid+"\n\tmobileno:\t"+m.mobileno+"\n\tHid:\t"+m.Hid+"\n\tZID:\t"+m.ZID);
                                                  
                                                }
                                                else if(option4==2)
                                                {
                                                 for(int i=0;i<m.Trhistory.length;i++) 
                                                   {
                                                   Console.WriteLine("___Transaction History___");
                                                   Console.WriteLine("Date  |  Type | amount | commision | Balance ");
                                                   Console.WriteLine(m.Trhistory[i]);
                                                   }
                                                   
                                                } 
                                                else if(option4==3)
                                                {
                                                 Console.WriteLine("___Change password___");
                                                 Console.WriteLine("Enter new password:");
                                                   string p1= sc.nextLine();
                                                   boolean f= isvalidPass(p1);
                                                  if(f==true){m.Password=p1;}
                                                Console.WriteLine("Password changed successfully:");
                                                } 
                                               else if(option4==4)
                                                {
                                                Console.WriteLine("___RC Transactions___");
                                                Console.WriteLine("Enter you options \n 1).Add Money \n 2) RemoveMoney 3)RC to ZC convert");
                                                  
                                                 string o5= sc.nextLine();
                                          	 int option5 = Integer.parseInt(o5);
                                                  			if(option5==1)
                                                  				{
                                                  				System.out.println("Add Money RC");
                                                  				string o6= sc.nextLine();
                                                  				int rc1 = Integer.parseInt(o6);
                                                  				m.Rc = m.Rc+rc1;
                                                  				System.out.println("Money added");
                                                  				}
                                                  			if(option5==2)
                                                  				{
                                                  				System.out.println("Remove Money RC");
                                                 				string o6= sc.nextLine();
                                                  				int rc1 = Integer.parseInt(o6);
                                                  				m.Rc = m.Rc-rc1;
                                                  				System.out.println("Money Removed");
                                                  				}
                                                  			if(option5==3)
                                                  				{
                                                  				System.out.println("Enter the RC to be converted to ZC");
                                                  				string o6= sc.nextLine();
                                                  				int rc1 = Integer.parseInt(o6);
                                                  				m.Rc = m.Rc-rc1;
                                                  				m.zc= m.zc+(rc1*2);
                                                  				System.out.println("ZC added");
                                                 				 }
                                                  
                                                } 
                                                else if(option4==5) 
                                                {
                                                   	System.out.println("___ZC Transactions___");
                                                  	System.out.println("Balance of ZC "+ m.zc);
                                                  
                                                  	System.out.println("Enter transact to ZID");
                                                   	string zidto= sc.nextLine();
                                                  	System.out.println("Enter ZC to be transferred");
                                                  	string o6= sc.nextLine();
                                                  	int zcc = Integer.parseInt(o6);
                                         		n=x.size(); 
                                         		c=-1;
                                         		int c1=0,c2=0;
                                         		for(int cus_tot=0;cus_tot<n;cus_tot++)
                                           		{
                                           
                                             		if ( (x.get(cus_tot).ZID).equals(zidto) )
                                             			{
                                             			 c2 = cus_tot;
                                             			}
                                           
                                            		 Customer tro = x.get(c2);
                                             		m.zc=m.zc - zcc;
                                             		tro.zc=tro.zc+zcc;
                                             		System.out.println("Balance of ZC "+ m.zc);

                                           		}       
                                                }
                                               
                                            Console.WriteLine("Enter you options \n 1).Account details \n 2).Transaction history  \n 3).Change password \n 4).RC transactions \n5)Zcoin transactions \n6) Press 0 to exit");
                               			o4= sc.nextLine();
                    			        option4 = Integer.parseInt(o4);
                                                
                                                 
                                              }
                                         } 
                                         
                                                 
                                         case 3:
                                               Console.WriteLine("*****  Thank you visit again  *****");
                                                 return ;
                                       }
                    case 2:
                      Console.WriteLine("__________Z-Coin Management( Admin-portal )___________");
                           Console.WriteLine("1.Employee Login");
                           Console.WriteLine("2.Back to home");
                           Console.WriteLine("Enter ur choice:"); 
                             string o3= sc.nextLine();
                              int choose = Integer.parseInt(o3);
                             switch(choose)
                              {
                                case 1:
                                      Console.WriteLine("Enter valid Email");
                                        string Emailid=sc.nextLine();
                                      Console.WriteLine("Enter password"); 
                                        string password =sc.nextLine();
                                       
                                      Console.WriteLine("Validating Credintials....");
                                        if(Emailid==emp.Emailid && password==emp.Password)
                                        {
                                        Console.WriteLine("Employee Login success");
                                        }
                                case 2:
                                    Console.WriteLine("*****  Thank you  *****");
                                                 return;
                                }
                }

          }
    }
  static boolean isvalidPass(string pas)
   {
    string pattern = "^(?=.*[^a-zA-Z])(?=.*[a-z])(?=.*[A-Z])\\S{8,}$";
    Pattern p = Pattern.compile(pattern);
    Matcher m = p.matcher(pas);
    boolean l = m.matches();
    return l;
    }

  }
  }
 
