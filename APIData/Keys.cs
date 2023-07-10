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


namespace APIData
{
    public partial class FormAPIData : Form
    {
        private List<KeyMethod> currentKeyMethods;
        private KeyMethod currentKeyMethod;

        private void LoadKeys()
        {
        }

        private void buttonAddKey_Click(object sender, EventArgs e)
        {
            var keyString = InputBox.ShowInputBox("Ключ доступа");
            if (keyString != null)
            {
                //keys.Add(keyString, apiMethods);
                //keys.Save();
                //listBoxKeys.Items.Add(keyString);
            }
        }

        private void listBoxKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKeys.SelectedIndex < 0)
                return;

            //keyAPIMethods.Rows.Clear();
            //currentKeyMethods = keys.GetKeyMethods(listBoxKeys.Text);
            //foreach (var item in currentKeyMethods)
            //{
            //    var rowIndex = keyAPIMethods.Rows.Add();
            //    var row = keyAPIMethods.Rows[rowIndex];
            //    row.Cells[0].Value = item.ApiMethod.Name;
            //    row.Cells[1].Value = item.TotalCount;
            //    row.Cells[2].Value = item.SpentCount;
            //    ;
            //}
        }

        private void keyAPIMethods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
