﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockTrackingSystem.Views.Debit;
using StockTrackingSystem.Views.Department;
using StockTrackingSystem.Views.Personnel;
using StockTrackingSystem.Views.Products;
using StockTrackingSystem.Views.Users;
using StockTrackingSystem.Controller;
using StockTrackingSystem.Model;

namespace StockTrackingSystem.Views.Users
{
    public partial class PersonnelMainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public PersonnelMainForm()
        {
            InitializeComponent();
        }

        private void PersonnelMainForm_Load(object sender, EventArgs e)
        {
            var resultPerson = PersonnelController.PersonnelDetail(LoginForm._personIDSession);
            var resultUser = UserController.UserFinder(LoginForm._userIDSession);
            lblName.Text = resultPerson.personName;
            lblLastName.Text = resultPerson.personLastName;
            lblUserName.Text = resultUser.userName;
            lblBirthDate.Text = Convert.ToDateTime(resultPerson.personBirthDate).ToShortDateString();
            lblDepartment.Text = resultPerson.departmentName;

            SetPersonnelMainFormByUserType(resultUser);
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionCEAddProduct_Click(object sender, EventArgs e)
        {
            FormRouter(1);
        }

        private void accordionCEAddStock_Click(object sender, EventArgs e)
        {
            FormRouter(2);
        }

        private void accordionCEEditProduct_Click(object sender, EventArgs e)
        {
            FormRouter(3);
        }

        private void accordionCEProductDeletion_Click(object sender, EventArgs e)
        {
            FormRouter(4);
        }

        private void accordionCEListProduct_Click(object sender, EventArgs e)
        {
            FormRouter(5);
        }

        private void accordionCEListPersonnel_Click(object sender, EventArgs e)
        {
            FormRouter(6);
        }

        private void accordionCEPersonnelDetail_Click(object sender, EventArgs e)
        {
            FormRouter(7);
        }

        private void accordionCEListDepartment_Click(object sender, EventArgs e)
        {
            FormRouter(8);
        }

        private void accordionCEAddDebit_Click(object sender, EventArgs e)
        {
            FormRouter(9);
        }

        private void accordionCEDebitDeletion_Click(object sender, EventArgs e)
        {
            FormRouter(10);
        }

        private void accordionCEEditDebit_Click(object sender, EventArgs e)
        {
            FormRouter(11);
        }

        private void accordionCEListMyDebiting_Click(object sender, EventArgs e)
        {
            FormRouter(12);
        }

        private void accordionCEChangePassword_Click(object sender, EventArgs e)
        {
            FormRouter(13);
        }

        private void accordionCELogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonnelMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public static void FormRouter(int willBeDirectedForm)
        {
            switch (willBeDirectedForm)
            {
                case (int)FormRouterController.AddProductForm:          //1
                    AddProductForm addProductForm = new AddProductForm();
                    addProductForm.ShowDialog();
                    break;
                case (int)FormRouterController.AddStockForm:            //2
                    AddStockForm addStockForm = new AddStockForm();
                    addStockForm.ShowDialog();
                    break;
                case (int)FormRouterController.EditProductForm:         //3
                    EditProductForm editProductForm = new EditProductForm();
                    editProductForm.ShowDialog();
                    break;
                case (int)FormRouterController.ProductDeletionForm:     //4
                    ProductDeletionForm productDeletionForm = new ProductDeletionForm();
                    productDeletionForm.ShowDialog();
                    break;
                case (int)FormRouterController.ListProductForm:         //5
                    ListProductForm listProductForm = new ListProductForm();
                    listProductForm.ShowDialog();
                    break;
                case (int)FormRouterController.ListPersonnelForm:       //6
                    ListPersonnelForm listPersonnelForm = new ListPersonnelForm();
                    listPersonnelForm.ShowDialog();
                    break;
                case (int)FormRouterController.PersonnelDetailForm:     //7
                    PersonnelDetailForm personnelDetailForm = new PersonnelDetailForm();
                    personnelDetailForm.ShowDialog();
                    break;
                case (int)FormRouterController.ListDepartmentForm:      //8
                    ListDepartmentForm listDepartmentForm = new ListDepartmentForm();
                    listDepartmentForm.ShowDialog();
                    break;
                case (int)FormRouterController.AddDebitForm:            //9
                    AddDebitForm addDebitForm = new AddDebitForm();
                    addDebitForm.ShowDialog();
                    break;
                case (int)FormRouterController.DebitDeletionForm:       //10
                    DebitDeletionForm debitDeletionForm = new DebitDeletionForm();
                    debitDeletionForm.ShowDialog();
                    break;
                case (int)FormRouterController.EditDebitForm:           //11
                    EditDebitForm editDebitForm = new EditDebitForm();
                    editDebitForm.ShowDialog();
                    break;
                case (int)FormRouterController.ListDebitForm:           //12
                    ListDebitForm listDebitForm = new ListDebitForm();
                    listDebitForm.ShowDialog();
                    break;
                case (int)FormRouterController.ChangePasswordForm:      //13
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                    changePasswordForm.ShowDialog();
                    break;
                default:
                    throw new Exception("There Was A Problem With Page Routing. The Page To Direct Is Not Found!");
            }
        }

        private void SetPersonnelMainFormByUserType(tblUsers user)
        {
            if (LoginForm._accountTypeSession.Equals(3))
            {
                accordionCEAddProduct.Visible = false;
                accordionControlSeparator6.Visible = false;

                accordionCEAddStock.Visible = false;
                accordionControlSeparator7.Visible = false;

                accordionCEEditProduct.Visible = false;
                accordionControlSeparator8.Visible = false;

                accordionCEProductDeletion.Visible = false;
                accordionControlSeparator10.Visible = false;

                accordionCEListProduct.Text = "List My Products";

                accordionCEPersonnelOperations.Visible = false;

                accordionCEAddDebit.Visible = false;
                accordionControlSeparator11.Visible = false;

                accordionCEDebitDeletion.Visible = false;
                accordionControlSeparator2.Visible = false;

                accordionCEEditDebit.Visible = false;
                accordionControlSeparator13.Visible = false;
            }
        }

        private void PersonnelMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Log Out?", "Log Out Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;               //If click 'Yes', log out

            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;                //If click 'No', log out is cancel
            }
        }
    }
}
