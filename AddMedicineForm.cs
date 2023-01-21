using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using PharmacyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmacyApp
{
    public partial class AddMedicineForm : Form
    {
        PharmacyCon Db = new PharmacyCon();
        
        public AddMedicineForm()
        {
            InitializeComponent();
        }

        public int MedicineId;
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
            dtgMedicine.DataSource=Db.Medicines.ToList(); 
            cmbCategories.Items.AddRange(Db.Categories.Select(c=>c.Name).ToArray());
            cmbFirms.Items.AddRange(Db.Firms.Select(c=>c.Name).ToArray());

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        void ClearData()
        {
            txtMedicinename.Text = txtDescription.Text= cmbCategories.Text= cmbFirms.Text=ckCategories.Text=string.Empty;
           
            nmCost.Value =nmSellprice.Value = nmCount.Value = 0;

        }

        private void dtgMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgMedicine.CurrentCell.RowIndex != -1)
                {
                    MedicineId = Convert.ToInt32(dtgMedicine.Rows[e.RowIndex].Cells[0].Value);
                    var med = Db.Medicines.Find(MedicineId);
                    txtMedicinename.Text = med.Name;
                    txtDescription.Text = med.Description;
                    ckIsreceipt.Checked = med.IsReceipt.Value;
                    nmSellprice.Value = med.Price.Value;
                    nmCost.Value = med.Cost.Value;
                    dtProducedate.Text = med.ProductionDate.ToString();
                    dtExpiredate.Text = med.ExpireDate.ToString();
                    nmCount.Value = med.Count;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void AddMedicine_Click(object sender, EventArgs e)
        {
            string name = txtMedicinename.Text;
            decimal cost = nmCost.Value;
            decimal price = nmSellprice.Value;
            bool IsReceipt = ckIsreceipt.Checked;
            int count = (int)nmCount.Value;
            DateTime proDate = dtProducedate.Value;
            DateTime expireDate = dtExpiredate.Value;
            string firmName = cmbFirms.Text;
            string description = txtDescription.Text;
            string category = cmbCategories.Text;

            if (!string.IsNullOrWhiteSpace(name) && price!=0)   
            {
                var newMedicine = new Medicine()
                {
                    Name = name,
                    Description = description,
                    IsReceipt = IsReceipt,
                    Price = price,
                    Cost = cost,
                    ProductionDate = proDate,
                    ExpireDate = expireDate,
                    Count = count,
                    
                    

                };
                Db.Medicines.Add(newMedicine);
                Db.SaveChanges();
                dtgMedicine.DataSource = Db.Medicines.ToList();
                //MessageBox.Show("Medicine is successfully added.", "New medicine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();

            }
            else
            {
                MessageBox.Show("Name and Price cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }



        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catname=cmbCategories.Text;
            if(!ckCategories.Items.Contains(catname)) {
                ckCategories.Items.Add(catname);
            }
        }

        private void cmbCategories_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                string catName=cmbCategories.Text;
                bool isCorrect = false;
                foreach(string cat in ckCategories.Items)
                {
                    if(cat.ToLower().Equals(catName.ToLower()))
                    {
                        isCorrect= true;
                    }
                if(!isCorrect)
                    {
                        ckCategories.Items.Add(catName);
                        cmbCategories.Text = "";
                    }
                }
            }
        }

        private void Update_Medicine_click(object sender, EventArgs e)
        {
            if (MedicineId > 0)
            {
                string name = txtMedicinename.Text;
                decimal cost = nmCost.Value;
                decimal price = nmSellprice.Value;
                bool IsReceipt = ckIsreceipt.Checked;
                int count = (int)nmCount.Value;
                DateTime proDate = dtProducedate.Value;
                DateTime expireDate = dtExpiredate.Value;
                string firmName = cmbFirms.Text;
                string description = txtDescription.Text;
                string category = cmbCategories.Text;

                var med = Db.Medicines.Find(MedicineId);
                med.Name = name;
                med.Price = price;
                med.ExpireDate = expireDate;
                med.Cost = cost;
                med.IsReceipt = IsReceipt;
                med.Description = description;
                med.ProductionDate = proDate;
                med.ExpireDate = expireDate;



                Db.Update<Medicine>(med);
                Db.SaveChanges();
                dtgMedicine.DataSource = Db.Medicines.ToList();
                //MessageBox.Show("Medicine is updated successfully.", "Updated data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please, select right data.", "Wrong selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void Delete_Medicine_click(object sender, EventArgs e)
        {
            if (MedicineId > 0)
            {
                string name = txtMedicinename.Text;
                decimal cost = nmCost.Value;
                decimal price = nmSellprice.Value;
                bool IsReceipt = ckIsreceipt.Checked;
                int count = (int)nmCount.Value;
                DateTime proDate = dtProducedate.Value;
                DateTime expireDate = dtExpiredate.Value;
                string firmName = cmbFirms.Text;
                string description = txtDescription.Text;
                string category = cmbCategories.Text;

                var med = Db.Medicines.Find(MedicineId);
                med.Name = name;
                med.Price = price;
                med.ExpireDate = expireDate;
                med.Cost = cost;
                med.IsReceipt = IsReceipt;
                med.Description = description;
                med.ProductionDate = proDate;
                med.ExpireDate = expireDate;



                Db.Remove<Medicine>(med);
                Db.SaveChanges();
                dtgMedicine.DataSource = Db.Medicines.ToList();
                //MessageBox.Show("Medicine is deleted successfully.", "Deleted data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please, select right data.", "Wrong selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void SearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchGuna.Text != string.Empty)
            {
                var items = Db.Medicines.Where(m => m.Name.Contains(txtSearchGuna.Text));
                dtgMedicine.DataSource = items.ToList();
            }
            else
            {
                dtgMedicine.DataSource = Db.Medicines.ToList();
            }


        }
    }
}
