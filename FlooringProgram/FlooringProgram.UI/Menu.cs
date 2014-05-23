using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Data;
using FlooringProgram.UI.WorkFlows;
using FlooringPrograms.Operations;
using Ninject;

namespace FlooringProgram.UI
{
    public class Menu
    {


        private static string userChoice;
        private IKernel _kernel;

        public void Run()
        {
            ConfigureIOC();

            do
            {

                DisplayMenu();
                userChoice = PromptUser();
                ProcessUserChoice();
            } while (userChoice != "Q");
        }

        private void ConfigureIOC()
        {
            _kernel = new StandardKernel(new FlooringMasteryModule());
        }

        private string PromptUser()
        {
            Console.Write("Enter choice: ");
            return Console.ReadLine();

        }


        public void DisplayMenu()
        {
            Console.WriteLine("1. Display Orders");
            Console.WriteLine("2. Add an Order");
            Console.WriteLine("3. Edit an Order");
            Console.WriteLine("4. Remove an Order");
            Console.WriteLine("Q to quit\n");

        }

        private void ProcessUserChoice()
        {

            switch (userChoice)
            {
                case "1":
                    DisplayOrdersWorkFlow disp = _kernel.Get<DisplayOrdersWorkFlow>();
                    disp.Execute();
                    break;

                case "2":
                    AddOrderWorkFlow add = _kernel.Get<AddOrderWorkFlow>();
                    add.Execute();
                    break;

                case "3":
                    EditOrderWorkFlow edit = _kernel.Get<EditOrderWorkFlow>();
                    edit.Execute();
                    break;

                case "4":
                    RemoveOrderWorkFlow remove = _kernel.Get<RemoveOrderWorkFlow>();
                    remove.Execute();
                    break;

                case "Q":
                    return;
            }
        }
    }
}
