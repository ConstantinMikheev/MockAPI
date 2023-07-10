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
        private Settings settings;

        private void LoadSettings()
        {
            settings = apiData.GetSettings();
            textBoxServerAPI.Text = settings.ServerAPI;
            textBoxTemplateResourceString.Text = settings.ResourceStringTemplate;
            textBoxMockServerPort.Text = settings.MockServerPort.ToString();
            foreach (var item in settings.Keys)
                listBoxKeysList.Items.Add(item);
        }

        private void textBoxServerAPI_TextChanged(object sender, EventArgs e)
        {
            settings.ServerAPI = textBoxServerAPI.Text;
            apiData.SaveSettings();
        }

        private void textBoxTemplateResourceString_TextChanged(object sender, EventArgs e)
        {
            settings.ResourceStringTemplate = textBoxTemplateResourceString.Text;
            apiData.SaveSettings();
        }

        private void textBoxMockServerPort_TextChanged(object sender, EventArgs e)
        {
            int port;
            if (int.TryParse(textBoxMockServerPort.Text, out port))
            {
                if (port <= 0 || port > 65535)
                {
                    MessageBox.Show("Необходимо указать число в диапазоне 1 - 65535", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    settings.MockServerPort = port;
                    apiData.SaveSettings();
                }
            } else
            {
                MessageBox.Show("Необходимо указать число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddDownloadKey_Click(object sender, EventArgs e)
        {
            var keyId = InputBox.ShowInputBox("Ключ доступа к API");
            if (keyId != null)
            {
                try
                {
                    apiData.AddDownloadKey(keyId);
                    listBoxKeysList.Items.Add(keyId);
                    apiData.SaveSettings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRemoveDownloadKey_Click(object sender, EventArgs e)
        {
            if (listBoxKeysList.SelectedIndex < 0)
                return;

            string keyId = listBoxKeysList.Text;
            if (MessageBox.Show($"Удалить ключ доступа {keyId}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            settings.RemoveKey(keyId);
            apiData.SaveSettings();
            listBoxKeysList.Items.Remove(listBoxKeysList.SelectedItem);
        }
    }
}
