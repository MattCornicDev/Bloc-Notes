﻿using Bloc_Note.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc_Note
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainMenuStrip menuStrip = new MainMenuStrip();
            Controls.Add(menuStrip);
        }
    }
}
