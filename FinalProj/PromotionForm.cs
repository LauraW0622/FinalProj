﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class PromotionForm : Form
    {
         public PromotionForm(PromotionalOffer p)
        {
            InitializeComponent();

            richTextBox1.Text = p.promos[1];
        }
    }
}
