using Essy.Tools.InputBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Model;
using System.IO;

namespace APIData
{
    public partial class FormAPIData : Form
    {
        private BL.APIData apiData;

        public FormAPIData()
        {
            InitializeComponent();

            apiData = new BL.APIData(Path.Combine(Path.GetTempPath(), "Kontur"));
            LoadSettings();
            LoadAPIMethods();
            LoadDataContent();
            LoadKeys();
        }
    }
}
