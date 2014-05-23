using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlooringProgram.Data;
using FlooringProgram.Data.Mocks;
using FlooringProgram.Models.DTOs;
using FlooringPrograms.Operations;
using Ninject;


namespace FlooringProgram.WinForm
{
    public partial class Form1 : Form
    {
        private OrderManager _myOrderManger;
        private ProductManager _myProductManager;
        private TaxRateManager _myTaxRateManager;
        private IKernel _kernel;
        private static List<Order> _currentLoadedOrders = new List<Order>();
        private static BindingList<Order> _currentOrdersBindingList;
        private string _filename;

        public Form1()
        {
            InitializeComponent();
            _kernel = new StandardKernel(new FlooringMasteryModule());
            _myOrderManger = _kernel.Get<OrderManager>();
            _myProductManager = _kernel.Get<ProductManager>();
            _myTaxRateManager = _kernel.Get<TaxRateManager>();
            cmbProdType.DataSource = _myProductManager.GetAllProducts().Select(x => x.ProductType).ToList();
            cmbState.DataSource = _myTaxRateManager.GetAllTaxRates().Select(x => x.State).ToList();
            cmbTaxRate.DataSource = _myTaxRateManager.GetAllTaxRates().Select(x => x.TaxPercent).ToList();


        }

        private void loadOrders_Click(object sender, EventArgs e)
        {
            _filename= "Orders_" + dateToLoad.Value.ToString("MMddyyyy") + ".txt";

            _currentLoadedOrders = _myOrderManger.LoadOrdersFromFile(_filename);
            _currentOrdersBindingList = new BindingList<Order>(_currentLoadedOrders);

            if (_currentLoadedOrders.Count == 0)
                MessageBox.Show("No orders for that date!", "Order Error");
            else
            {
                dataOrdersView.DataSource = _currentOrdersBindingList;
            }
        }

        private void addOrders_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a customer name.");
                return;

            }

            Order o = new Order();
            {
                o.OrderNumber = 1;  //make this 1 for now
                o.Name = txtName.Text;
                o.State = cmbState.SelectedItem.ToString();
                o.TaxRate = _myTaxRateManager.GetAllTaxRates().FirstOrDefault(x => x.State == o.State).TaxPercent;
                o.ProductType = cmbProdType.SelectedItem.ToString();
                o.Area = upDownArea.Value;
                o.CostPerSquareFoot =
                    _myProductManager.GetAllProducts()
                        .FirstOrDefault(x => x.ProductType == o.ProductType)
                        .CostPerSquareFoot;
                o.LaborCostPerSquareFoot = _myProductManager.GetAllProducts()
                        .FirstOrDefault(x => x.ProductType == o.ProductType)
                        .LaborCostPerSquareFoot;
                o.MaterialCost = o.Area * o.CostPerSquareFoot;
                o.LaborCost = o.Area * o.LaborCostPerSquareFoot;
                o.Tax = o.MaterialCost * o.TaxRate;
                o.Total = o.MaterialCost + o.LaborCost + o.Tax;
                _currentLoadedOrders.Add(o);


            };

            DialogResult result = MessageBox.Show("Are you sure you want to add this order?", "Confirm Order", MessageBoxButtons.YesNo);
            

            if (result == DialogResult.Yes)
            {
                _myOrderManger.SaveOrdersToFile(_currentLoadedOrders, _filename);
                RefreshOrdersView();
            }
        }

        private void RefreshOrdersView()
        {
            _currentOrdersBindingList=new BindingList<Order>(_currentLoadedOrders);
            dataOrdersView.DataSource = _currentOrdersBindingList;
        }


        private void textBox_EnterName(object sender, EventArgs e)
        {

        }

        private void comboBox_ProdSelector(object sender, EventArgs e)
        {

        }

        private void comboBox_StateSelector(object sender, EventArgs e)
        {

        }

        private void updown_AreaNumeric(object sender, EventArgs e)
        {

        }



        
    }
}
