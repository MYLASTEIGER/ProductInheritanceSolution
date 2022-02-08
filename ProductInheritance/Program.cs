using System;
using System.Collections.Generic;

namespace ProductInheritance {
    class Program {
        static void Main(string[] args) {

            

            List<Product> salesOrder = new List<Product>();
            Product widget1 = new Widget("W1", 50, "small", "red");
            Product widget2 = new Widget("W2", 100, "medium", "white");
            Product widget3 = new Widget("W3", 200, "Large", "Blue");
            Product service = new Service("SVC", 500, "Premium", 5);
            Product software = new Software("SFTW", 150, true);
            
            salesOrder.Add(widget1);
            salesOrder.Add(widget2);
            salesOrder.Add(widget3);
            salesOrder.Add(service);
            salesOrder.Add(software);

            decimal salesOrderTotal = 0;

            foreach (Product p in salesOrder) {
            salesOrderTotal += p.Price;
                if (p is Widget) {
                    Widget w = p as Widget;
                    Console.WriteLine($"{w.Code} {w.Price:c} {w.Size}, {w.Color}");
                    continue;
                }
                if (p is Service) {
                    Service s = p as Service;
                    Console.WriteLine($"{s.Code}, {s.Price:c}, {s.ServiceLevel}, {s.NumberofYears}");
                    continue;
                } 
                if (p is Software) {
                    Software sf = p as Software;
                    Console.WriteLine($"{sf.Code}, {sf.Price:c}, {(sf.Book ? "With Book" : "Without Book")}");
                    continue;
                }
            }
            Console.WriteLine($"Total sales order is {salesOrderTotal:c}");


           /* Service s1 = new Service("Basic", 100, "Basic", 3);
            Console.WriteLine(s1.ToPrint());

            Widget w = new Widget("Widget",543.21m, "Large", "MAX Red");
            w.Code = "Widget2";
            w.Price = 543.32m;
            Console.WriteLine(w.ToPrint());

            Product p = new Product("Echo", 123.45m);
            string message = p.ToPrint();
            Console.WriteLine(message);*/
        }
    }
}
