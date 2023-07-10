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
using System.Runtime.CompilerServices;

namespace APIData
{
    public partial class FormAPIData : Form
    {
        private DataContent dataContent = new DataContent();
        private string currentRequestString;
        private string currentDataPath;

        private void LoadDataContent()
        {
            dataContent = apiData.GetDataContent();
            foreach(var item in dataContent.GetRequestStrings())
                checkedListBoxData.Items.Add(item);
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            var dataRequestString = InputBox.ShowInputBox("Данные для загрузки");
            if (dataRequestString != null)
            {
                try
                {
                    apiData.AddContentRequestString(dataRequestString);
                    checkedListBoxData.Items.Add(dataRequestString);
                    apiData.SaveDataContentSettings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRemoveData_Click(object sender, EventArgs e)
        {
            if (checkedListBoxData.SelectedIndex < 0)
                return;

            string requestString = checkedListBoxData.Text;
            if (MessageBox.Show($"Удалить строку запроса {requestString}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            dataContent.Remove(requestString);
            apiData.SaveDataContentSettings();
            checkedListBoxData.Items.Remove(checkedListBoxData.SelectedItem);
        }

        private void checkedListBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxData.SelectedIndex < 0)
                return;

            listBoxDataMethods.Items.Clear();
            var dataMethods = dataContent.GetDataMethodContents(checkedListBoxData.Text);
            currentRequestString = checkedListBoxData.Text;
            foreach (var item in dataMethods)
            {
                var curMethod = item.ApiMethod;
                listBoxDataMethods.Items.Add(curMethod.Name);
            }
        }

        private void buttonLoadDataFromAPI_Click(object sender, EventArgs e)
        {
            var listForDownloads = new List<string>();

            foreach (var item in checkedListBoxData.CheckedItems)
                listForDownloads.Add(item.ToString());

            if (listForDownloads.Count == 0)
            {
                if (MessageBox.Show("Не выбраны данные для загрузки. Загрузить весь список?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    foreach (var item in checkedListBoxData.Items)
                        listForDownloads.Add(item.ToString());
            }
            if (listForDownloads.Count > 0)
            {
                apiData.LoadDataFromAPI(listForDownloads);
                MessageBox.Show("Загрузка завершена");
            }
        }

        private void listBoxDataMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDataContent.Clear();

            var curPath = "";
            var curMethods = apiData.GetContent(currentRequestString);
            foreach (var item in curMethods)
                if (item.ApiMethod.Name == listBoxDataMethods.Text)
                {
                    curPath = item.ContentPath;
                    break;
                }
            if (!string.IsNullOrEmpty(curPath) && File.Exists(curPath))
                textBoxDataContent.Text = File.ReadAllText(curPath);
        }
    }
}
