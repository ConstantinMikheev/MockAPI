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
        private APIMethods apiMethods;
        private APIMethod currentMethod;

        /// <summary>
        /// Считывает список методов из файла. Если файл не существует, создает новый список методов
        /// </summary>
        void LoadAPIMethods()
        {
            apiMethods = apiData.GetAPIMethods();
            foreach (var item in apiMethods)
                listBoxAPIMethods.Items.Add((item as APIMethod).Name);
        }

        #region Create and remove API methods
        /// <summary>
        /// Создание нового метода API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAPIMethod_Click(object sender, EventArgs e)
        {
            var methodName = InputBox.ShowInputBox("Имя метода");
            if (methodName != null)
            {
                try
                {
                    apiData.AddAPIMethod(methodName);
                    listBoxAPIMethods.Items.Add(methodName);
                    apiData.SaveAPIMethods();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Удаление метода из списка методов API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteAPIMethod_Click(object sender, EventArgs e)
        {
            if (listBoxAPIMethods.SelectedIndex < 0)
                return;

            string methodName = listBoxAPIMethods.Text;
            if (MessageBox.Show($"Удалить метод {methodName}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            apiData.RemoveAPIMethod(methodName);
            apiData.SaveAPIMethods();
            listBoxAPIMethods.Items.Remove(listBoxAPIMethods.SelectedItem);
            panelAPIMethodInfo.Visible = false;
        }
        #endregion

        /// <summary>
        /// При выборе метода в списке методов заполняет форму его настройками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAPIMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAPIMethodInfo.Visible = false;

            if (listBoxAPIMethods.SelectedIndex < 0)
                return;

            string methodName = listBoxAPIMethods.Text;
            currentMethod = apiData.GetAPIMethod(methodName);
            if (currentMethod == null)
                return;

            checkBoxDownloadAllow.Checked = currentMethod.Enabled;
            textBoxResourceString.Text = currentMethod.ResourceString;
            panelAPIMethodInfo.Visible = true;
        }

        #region Settings change
        /// <summary>
        /// Включение или отключение метода для загрузки по нему данным из API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDownloadAllow_CheckedChanged(object sender, EventArgs e)
        {
            currentMethod.Enabled = checkBoxDownloadAllow.Checked;
            apiData.SaveAPIMethods();
        }

        /// <summary>
        /// Строка запроса метода по http
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxResourceString_TextChanged(object sender, EventArgs e)
        {
            currentMethod.ResourceString = textBoxResourceString.Text;
            apiData.SaveAPIMethods();
        }
        #endregion
    }
}
