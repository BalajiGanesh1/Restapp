using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenuApp
{
 
    class Item
    {
        
        public string item_name;
        public long price;
        public int no_of_plates;

        public void setInfo(string item_name,long price,int no_of_plates=0)
        {
           
            this.item_name = item_name;
            this.price = price;
            this.no_of_plates = no_of_plates;
          
        }

    }

  
    class Starters:Item
   {
        static List<Item> StartersMenu = new List<Item>();

        public void initialiseMenu()
        {
            Item starter = new Item();
            starter.setInfo("Gobi-65", 50);
            StartersMenu.Add(starter);

            Item starter2 = new Item();
            starter2.setInfo("Paneer-65", 100);
            StartersMenu.Add(starter2);

            Item starter3 = new Item();
            starter3.setInfo("BabyCorn-65", 80);
            StartersMenu.Add(starter3);

            Item starter4 = new Item();
            starter4.setInfo("Kadai Veg", 60);
            StartersMenu.Add(starter4);

            Item starter5 = new Item();
            starter5.setInfo("Garlic Bread", 75);
            StartersMenu.Add(starter5);


        }
        internal void display()
        {

            Console.WriteLine("S.no"+"\t\t" + "Name of Dish" + "\t\t\t" + "Price\n\n");
            int i = 0;
            foreach (Item items in StartersMenu)
            {
                ++i;
                Console.Write(i);

                if(i==1)
                    Console.WriteLine("\t\t"+ items.item_name+ "\t\t\t\t"+ items.price+"\n");
                else
                    Console.WriteLine("\t\t" + items.item_name + "\t\t\t" + items.price+"\n");


            }
        }

        internal string getSelectedItem(int sno)
        {
            return StartersMenu[sno - 1].item_name;
        }

        internal void set_no_of_plates(int sno, int no_of_plates)
        {
            StartersMenu[sno - 1].no_of_plates = no_of_plates;
            
        }

        internal int get_no_of_plates(int sno)
        {
            return StartersMenu[sno - 1].no_of_plates;

        }

        internal long get_price(int sno)
        {
            return StartersMenu[sno - 1].price;

        }

        internal Item getOrderedItem(int sno)
        {
            return StartersMenu[sno - 1];
        }
    }


    class MainCourses : Item
    {
        static List<Item> MainCoursesMenu = new List<Item>();

        public void initialiseMenu()
        {
            Item maincourse = new Item();
            maincourse.setInfo("Butter Nan", 30);
            MainCoursesMenu.Add(maincourse);

            Item maincourse2 = new Item();
            maincourse2.setInfo("Paneer Rice", 100);
            MainCoursesMenu.Add(maincourse2);

            Item maincourse3 = new Item();
            maincourse3.setInfo("Gobi Fried Rice", 70);
            MainCoursesMenu.Add(maincourse3);

            Item maincourse4 = new Item();
            maincourse4.setInfo("Romali Roti", 40);
            MainCoursesMenu.Add(maincourse4);

            Item maincourse5 = new Item();
            maincourse5.setInfo("Mushroom Rice", 80);
            MainCoursesMenu.Add(maincourse5);


        }
        internal void display()
        {

            Console.WriteLine("S.no" + "\t\t" + "Name of Dish" + "\t\t\t" + "Price\n\n");
            int i = 0;
            foreach (Item items in MainCoursesMenu)
            {
                ++i;
                Console.Write(i);

              
                Console.WriteLine("\t\t" + items.item_name + "\t\t\t" + items.price + "\n");

               



            }
        }

        internal string getSelectedItem(int sno)
        {
            return MainCoursesMenu[sno - 1].item_name;
        }

        internal void set_no_of_plates(int sno, int no_of_plates)
        {
            MainCoursesMenu[sno - 1].no_of_plates = no_of_plates;

        }

        internal int get_no_of_plates(int sno)
        {
            return MainCoursesMenu[sno - 1].no_of_plates;

        }

        internal long get_price(int sno)
        {
            return MainCoursesMenu[sno - 1].price;

        }

        internal Item getOrderedItem(int sno)
        {
            return MainCoursesMenu[sno - 1];
        }
    }


    class Deserts : Item
    {
        static List<Item> DesertsMenu = new List<Item>();

        public void initialiseMenu()
        {
            Item desert = new Item();
            desert.setInfo("Pista Coco", 90);
            DesertsMenu.Add(desert);

            Item desert2 = new Item();
            desert2.setInfo("Lassi Rain", 40);
            DesertsMenu.Add(desert2);

            Item desert3 = new Item();
            desert3.setInfo("Choco Run", 60);
            DesertsMenu.Add(desert3);

            Item desert4 = new Item();
            desert4.setInfo("Falooda XL", 140);
            DesertsMenu.Add(desert4);

            Item desert5 = new Item();
            desert5.setInfo("Berry Blast", 90);
            DesertsMenu.Add(desert5);


        }
        internal void display()
        {

            Console.WriteLine("S.no" + "\t\t" + "Name of Dish" + "\t\t\t" + "Price\n\n");
            int i = 0;
            foreach (Item item in DesertsMenu)
            {
                ++i;
                Console.Write(i);
                Console.WriteLine("\t\t" + item.item_name + "\t\t\t" + item.price + "\n");



            }
        }

        internal string getSelectedItem(int sno)
        {
            return DesertsMenu[sno - 1].item_name;
        }

        internal void set_no_of_plates(int sno, int no_of_plates)
        {
            DesertsMenu[sno - 1].no_of_plates = no_of_plates;

        }

        internal int get_no_of_plates(int sno)
        {
            return DesertsMenu[sno - 1].no_of_plates;

        }

        internal long get_price(int sno)
        {
            return DesertsMenu[sno - 1].price;

        }

        internal Item getOrderedItem(int sno)
        {
            return DesertsMenu[sno - 1];
        }
    }

    class BillGenerator
    {
        public static double billAmount;
        public static List<Item> AllItemsOrdered = new List<Item>();

        public static void AddToBill(Item orderedItem)
        {
            AllItemsOrdered.Add(orderedItem);
            billAmount += orderedItem.price * orderedItem.no_of_plates;
        }

        internal static void display()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t******** BILL *********");
            Console.WriteLine("S.no" + "\t" + "Name of Dish" + "\t" + "Price" +"\t"+"No of Plates"+"\t"+"Total Amount"+"\n\n");
            int i = 0;
            foreach (Item item in AllItemsOrdered)
            {
                ++i;
                Console.Write(i);


                if(item.item_name=="Gobi-65")
                    Console.WriteLine("\t" + item.item_name + "\t\t" + item.price + "\t\t" + item.no_of_plates + "\t" + item.no_of_plates * item.price + "\n");

                else
                Console.WriteLine("\t" + item.item_name + "\t" + item.price + "\t\t" + item.no_of_plates + "\t" + item.no_of_plates*item.price+"\n");

            }
            Console.WriteLine("\t\t\t\t\t\t" + "-------------------\n\n");
            Console.WriteLine("\t\t BILL AMOUNT\t\t\t" + billAmount);
            Console.WriteLine("\t\t\t\t\t\t" + "-------------------\n\n");
            Console.WriteLine("\t\t\t*******  THANK YOU *******\n\n");
        }
    }

   



    class MenuAndBillPrinter
    {   
        static void displayMainMenu()
        {
            Console.WriteLine("\t\t\t 1.Starters\n " +
                              "\t\t\t 2.Main Course\n" +
                              "\t\t\t 3.Deserts\n" +
                              "\t\t\t 4.Bill");
           
        }

        static void displayHeader()
        {
            Console.WriteLine("\t\t\t Welcome To Hotel TransylVania\n\n");
        }
        static void Main(string[] args)
        {
            int menuType;
            string dineAgain;
            int starter_asked_count = 0;
            int mainCourse_asked_count = 0;
            int desert_asked_count = 0;



            do
           {
                BillGenerator.billAmount = 0;
                BillGenerator.AllItemsOrdered.Clear();
                string goToMainMenu;
                     do
                     {

                            Console.Clear();
                            displayHeader();
                            displayMainMenu();
                            Console.Write("\n\n\t\tHelp us Show the Dishes available(Enter 1/2/3)\t");
                            menuType = Convert.ToInt32(Console.ReadLine());   //menuType 1=Starters 2=Main course 3=Desert 4=Bill
                        
                            switch (menuType)
                            {
                               case 1:
                                  {

                                      
                                       Starters starters = new Starters();

                                       if(starter_asked_count++==0)
                                       starters.initialiseMenu();

                                       string moreStarters;
                                       do
                                       {
                                           int sno, no_of_plates;
                                           string inputItemNo;
                                      
                                           Console.Clear();
                                           displayHeader();
                                           starters.display();
                                           Console.Write("Enter S.no of Item you want\t:");
                                           inputItemNo = Console.ReadLine();
                                           sno = int.Parse(inputItemNo);
                                           
                                      
                                           Console.Write("How many plates of " + starters.getSelectedItem(sno) + " do you want?");
                                           no_of_plates = int.Parse(Console.ReadLine());
                                           starters.set_no_of_plates(sno, no_of_plates);
                                      
                                           Console.WriteLine(starters.get_no_of_plates(sno) + " plates of" + starters.getSelectedItem(sno) + " ordered !\n");

                                           Item orderedItem = starters.getOrderedItem(sno);
                                           BillGenerator.AddToBill(orderedItem);

                                           
                                           Console.Write("Any more Starters?(Reply Y/N)\t\t:");
                                           moreStarters = Console.ReadLine();
                                      
                                       } while (moreStarters == "y" || moreStarters == "Y");
                                      
                                       break;

                                  }

                       
                                case 2:
                                  {
                                    MainCourses mainCourses = new MainCourses();
                                  
                                    if (mainCourse_asked_count++ == 0)
                                        mainCourses.initialiseMenu();
                                  
                                    string moreMainCourses;
                                        do
                                        {
                                            int sno, no_of_plates;
                                            string inputItemNo;
                                        
                                            Console.Clear();
                                            displayHeader();
                                            mainCourses.display();
                                            Console.Write("Enter S.no of Item you want\t:");
                                            inputItemNo = Console.ReadLine();
                                            sno = int.Parse(inputItemNo);
                                        
                                        
                                            Console.Write("How many plates of " + mainCourses.getSelectedItem(sno) + " do you want?");
                                            no_of_plates = int.Parse(Console.ReadLine());
                                            mainCourses.set_no_of_plates(sno, no_of_plates);
                                        
                                            Console.WriteLine(mainCourses.get_no_of_plates(sno) + " plates of" + mainCourses.getSelectedItem(sno) + " ordered !\n");
                                        
                                            Item orderedItem = mainCourses.getOrderedItem(sno);
                                            BillGenerator.AddToBill(orderedItem);
                                        
                                            
                                            Console.Write("Any more MainCourse?(Reply Y/N)\t\t:");
                                            moreMainCourses = Console.ReadLine();
                                        
                                        } while (moreMainCourses == "y" || moreMainCourses == "Y");
                                        
                                    break;
                                        

                                  }
                            
                             
                             case 3:
                              {
                                  Deserts deserts = new Deserts();
                                  
                                  if (desert_asked_count++ == 0)
                                      deserts.initialiseMenu();
                                  
                                  string moreDeserts;
                                  do
                                  {
                                      int sno, no_of_plates;
                                      string inputItemNo;
                                  
                                      Console.Clear();
                                      displayHeader();
                                      deserts.display();
                                      Console.Write("Enter S.no of Item you want\t:");
                                      inputItemNo = Console.ReadLine();
                                      sno = int.Parse(inputItemNo);
                                  
                                  
                                      Console.Write("How many plates of " + deserts.getSelectedItem(sno) + " do you want?");
                                      no_of_plates = int.Parse(Console.ReadLine());
                                      deserts.set_no_of_plates(sno, no_of_plates);
                                  
                                      Console.WriteLine(deserts.get_no_of_plates(sno) + " plates of" + deserts.getSelectedItem(sno) + " ordered !\n");
                                  
                                      Item orderedItem = deserts.getOrderedItem(sno);
                                      BillGenerator.AddToBill(orderedItem);
                                  
                                      
                                      Console.Write("Any more Deserts?(Reply Y/N)\t\t:");
                                      moreDeserts = Console.ReadLine();
                                  
                                  } while (moreDeserts == "y" || moreDeserts == "Y");
                                  
                                  break;
                                  

                              }
                          
                              case 4:
                               {
                                    
                                     BillGenerator.display();
                                     break;

                               }


                                


                    }

                    Console.Write("Go to Main Menu ??(Reply Y/N)\t\t");
                            goToMainMenu = Console.ReadLine();
                        
                     } while (goToMainMenu == "y" || goToMainMenu == "Y");
                        

                Console.Write("Dine again?(Reply Y/N)\t\t:");
                dineAgain = Console.ReadLine();

           } while (dineAgain == "y" || dineAgain == "Y") ;
            
            
            Console.ReadLine();
        
        }

       
    }
}
