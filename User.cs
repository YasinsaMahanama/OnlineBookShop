﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void BookBtnU_Click(object sender, EventArgs e)
        {
            // Create an instance of the Book form
            Book bookForm = new Book();

            // Show the Book form
            bookForm.Show();

            // Hide the current User form
            this.Hide();
        }

        private void UserBtnU_Click(object sender, EventArgs e)
        {
            // Create an instance of the User form
            User userForm = new User();

            // Show the User form
            userForm.Show();

            // Hide the current User form
            this.Hide();
        }

        private void InStockBtnU_Click(object sender, EventArgs e)
        {
            // Create an instance of the In Stock form
            InStock inStockForm = new InStock();

            // Show the In Stock form
            inStockForm.Show();

            // Hide the current User form
            this.Hide();
        }

        private void SaleBtnU_Click(object sender, EventArgs e)
        {
            // Create an instance of the Sale form
            Sale saleForm = new Sale();

            // Show the Sale form
            saleForm.Show();

            // Hide the current User form
            this.Hide();
        }

        private void AboutBtnU_Click(object sender, EventArgs e)
        {
            // Create an instance of the About form
            About aboutForm = new About();

            // Show the About form
            aboutForm.Show();

            // Hide the current User form
            this.Hide();
        }

        private void ContactBtnU_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Contact contactForm = new Contact();

            // Show the About form
            contactForm.Show();

            // Hide the current User form
            this.Hide();
        }

        private void HomeBtnU_Click(object sender, EventArgs e)
        {
            // Create an instance of the Home form
            Home HomeForm = new Home();

            // Show the Home form
            HomeForm.Show();

            // Hide the current User form
            this.Hide();
        }
    }
}
