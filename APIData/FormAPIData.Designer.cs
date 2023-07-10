namespace APIData
{
    partial class FormAPIData
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAPIData = new System.Windows.Forms.TabPage();
            this.labelDataMethods = new System.Windows.Forms.Label();
            this.buttonRemoveData = new System.Windows.Forms.Button();
            this.listBoxDataMethods = new System.Windows.Forms.ListBox();
            this.checkedListBoxData = new System.Windows.Forms.CheckedListBox();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.labelDataList = new System.Windows.Forms.Label();
            this.tabMethodsSettings = new System.Windows.Forms.TabPage();
            this.buttonDeleteAPIMethod = new System.Windows.Forms.Button();
            this.panelAPIMethodInfo = new System.Windows.Forms.Panel();
            this.textBoxResourceString = new System.Windows.Forms.TextBox();
            this.labelResourceString = new System.Windows.Forms.Label();
            this.checkBoxDownloadAllow = new System.Windows.Forms.CheckBox();
            this.buttonAddAPIMethod = new System.Windows.Forms.Button();
            this.labelAPIMethods = new System.Windows.Forms.Label();
            this.listBoxAPIMethods = new System.Windows.Forms.ListBox();
            this.tabKeys = new System.Windows.Forms.TabPage();
            this.keyAPIMethods = new System.Windows.Forms.DataGridView();
            this.MethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddKey = new System.Windows.Forms.Button();
            this.listBoxKeys = new System.Windows.Forms.ListBox();
            this.tabBaseSettings = new System.Windows.Forms.TabPage();
            this.buttonRemoveDownloadKey = new System.Windows.Forms.Button();
            this.buttonAddDownloadKey = new System.Windows.Forms.Button();
            this.listBoxKeysList = new System.Windows.Forms.ListBox();
            this.labelKeysList = new System.Windows.Forms.Label();
            this.textBoxMockServerPort = new System.Windows.Forms.TextBox();
            this.labelMockServerPort = new System.Windows.Forms.Label();
            this.textBoxTemplateResourceString = new System.Windows.Forms.TextBox();
            this.labelTemplateResourceString = new System.Windows.Forms.Label();
            this.textBoxServerAPI = new System.Windows.Forms.TextBox();
            this.labelServerAPI = new System.Windows.Forms.Label();
            this.textBoxDataContent = new System.Windows.Forms.TextBox();
            this.buttonLoadDataFromAPI = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAPIData.SuspendLayout();
            this.tabMethodsSettings.SuspendLayout();
            this.panelAPIMethodInfo.SuspendLayout();
            this.tabKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyAPIMethods)).BeginInit();
            this.tabBaseSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAPIData);
            this.tabControl1.Controls.Add(this.tabMethodsSettings);
            this.tabControl1.Controls.Add(this.tabKeys);
            this.tabControl1.Controls.Add(this.tabBaseSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAPIData
            // 
            this.tabAPIData.Controls.Add(this.buttonLoadDataFromAPI);
            this.tabAPIData.Controls.Add(this.textBoxDataContent);
            this.tabAPIData.Controls.Add(this.labelDataMethods);
            this.tabAPIData.Controls.Add(this.buttonRemoveData);
            this.tabAPIData.Controls.Add(this.listBoxDataMethods);
            this.tabAPIData.Controls.Add(this.checkedListBoxData);
            this.tabAPIData.Controls.Add(this.buttonAddData);
            this.tabAPIData.Controls.Add(this.labelDataList);
            this.tabAPIData.Location = new System.Drawing.Point(4, 22);
            this.tabAPIData.Name = "tabAPIData";
            this.tabAPIData.Padding = new System.Windows.Forms.Padding(3);
            this.tabAPIData.Size = new System.Drawing.Size(797, 423);
            this.tabAPIData.TabIndex = 0;
            this.tabAPIData.Text = "Данные из API";
            this.tabAPIData.UseVisualStyleBackColor = true;
            // 
            // labelDataMethods
            // 
            this.labelDataMethods.AutoSize = true;
            this.labelDataMethods.Location = new System.Drawing.Point(347, 42);
            this.labelDataMethods.Name = "labelDataMethods";
            this.labelDataMethods.Size = new System.Drawing.Size(110, 13);
            this.labelDataMethods.TabIndex = 6;
            this.labelDataMethods.Text = "Список методов API";
            // 
            // buttonRemoveData
            // 
            this.buttonRemoveData.Location = new System.Drawing.Point(92, 29);
            this.buttonRemoveData.Name = "buttonRemoveData";
            this.buttonRemoveData.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveData.TabIndex = 5;
            this.buttonRemoveData.Text = "Удалить";
            this.buttonRemoveData.UseVisualStyleBackColor = true;
            this.buttonRemoveData.Click += new System.EventHandler(this.buttonRemoveData_Click);
            // 
            // listBoxDataMethods
            // 
            this.listBoxDataMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxDataMethods.FormattingEnabled = true;
            this.listBoxDataMethods.Location = new System.Drawing.Point(350, 58);
            this.listBoxDataMethods.Name = "listBoxDataMethods";
            this.listBoxDataMethods.Size = new System.Drawing.Size(204, 355);
            this.listBoxDataMethods.TabIndex = 4;
            // 
            // checkedListBoxData
            // 
            this.checkedListBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxData.FormattingEnabled = true;
            this.checkedListBoxData.Location = new System.Drawing.Point(11, 58);
            this.checkedListBoxData.Name = "checkedListBoxData";
            this.checkedListBoxData.Size = new System.Drawing.Size(333, 349);
            this.checkedListBoxData.TabIndex = 3;
            this.checkedListBoxData.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxData_SelectedIndexChanged);
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(11, 29);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(75, 23);
            this.buttonAddData.TabIndex = 2;
            this.buttonAddData.Text = "Добавить";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // labelDataList
            // 
            this.labelDataList.AutoSize = true;
            this.labelDataList.Location = new System.Drawing.Point(8, 13);
            this.labelDataList.Name = "labelDataList";
            this.labelDataList.Size = new System.Drawing.Size(118, 13);
            this.labelDataList.TabIndex = 0;
            this.labelDataList.Text = "Данные для загрузки";
            // 
            // tabMethodsSettings
            // 
            this.tabMethodsSettings.Controls.Add(this.buttonDeleteAPIMethod);
            this.tabMethodsSettings.Controls.Add(this.panelAPIMethodInfo);
            this.tabMethodsSettings.Controls.Add(this.buttonAddAPIMethod);
            this.tabMethodsSettings.Controls.Add(this.labelAPIMethods);
            this.tabMethodsSettings.Controls.Add(this.listBoxAPIMethods);
            this.tabMethodsSettings.Location = new System.Drawing.Point(4, 22);
            this.tabMethodsSettings.Name = "tabMethodsSettings";
            this.tabMethodsSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMethodsSettings.Size = new System.Drawing.Size(797, 423);
            this.tabMethodsSettings.TabIndex = 1;
            this.tabMethodsSettings.Text = "Настройки методов API";
            this.tabMethodsSettings.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAPIMethod
            // 
            this.buttonDeleteAPIMethod.Location = new System.Drawing.Point(88, 22);
            this.buttonDeleteAPIMethod.Name = "buttonDeleteAPIMethod";
            this.buttonDeleteAPIMethod.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAPIMethod.TabIndex = 4;
            this.buttonDeleteAPIMethod.Text = "Удалить";
            this.buttonDeleteAPIMethod.UseVisualStyleBackColor = true;
            this.buttonDeleteAPIMethod.Click += new System.EventHandler(this.buttonDeleteAPIMethod_Click);
            // 
            // panelAPIMethodInfo
            // 
            this.panelAPIMethodInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAPIMethodInfo.Controls.Add(this.textBoxResourceString);
            this.panelAPIMethodInfo.Controls.Add(this.labelResourceString);
            this.panelAPIMethodInfo.Controls.Add(this.checkBoxDownloadAllow);
            this.panelAPIMethodInfo.Location = new System.Drawing.Point(211, 48);
            this.panelAPIMethodInfo.Name = "panelAPIMethodInfo";
            this.panelAPIMethodInfo.Size = new System.Drawing.Size(580, 368);
            this.panelAPIMethodInfo.TabIndex = 3;
            this.panelAPIMethodInfo.Visible = false;
            // 
            // textBoxResourceString
            // 
            this.textBoxResourceString.Location = new System.Drawing.Point(12, 64);
            this.textBoxResourceString.Name = "textBoxResourceString";
            this.textBoxResourceString.Size = new System.Drawing.Size(343, 20);
            this.textBoxResourceString.TabIndex = 2;
            this.textBoxResourceString.TextChanged += new System.EventHandler(this.textBoxResourceString_TextChanged);
            // 
            // labelResourceString
            // 
            this.labelResourceString.AutoSize = true;
            this.labelResourceString.Location = new System.Drawing.Point(9, 48);
            this.labelResourceString.Name = "labelResourceString";
            this.labelResourceString.Size = new System.Drawing.Size(88, 13);
            this.labelResourceString.TabIndex = 1;
            this.labelResourceString.Text = "Строка запроса";
            // 
            // checkBoxDownloadAllow
            // 
            this.checkBoxDownloadAllow.AutoSize = true;
            this.checkBoxDownloadAllow.Location = new System.Drawing.Point(12, 17);
            this.checkBoxDownloadAllow.Name = "checkBoxDownloadAllow";
            this.checkBoxDownloadAllow.Size = new System.Drawing.Size(167, 17);
            this.checkBoxDownloadAllow.TabIndex = 0;
            this.checkBoxDownloadAllow.Text = "Разрешена загрузка из API";
            this.checkBoxDownloadAllow.UseVisualStyleBackColor = true;
            this.checkBoxDownloadAllow.CheckedChanged += new System.EventHandler(this.checkBoxDownloadAllow_CheckedChanged);
            // 
            // buttonAddAPIMethod
            // 
            this.buttonAddAPIMethod.Location = new System.Drawing.Point(7, 22);
            this.buttonAddAPIMethod.Name = "buttonAddAPIMethod";
            this.buttonAddAPIMethod.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAPIMethod.TabIndex = 2;
            this.buttonAddAPIMethod.Text = "Добавить";
            this.buttonAddAPIMethod.UseVisualStyleBackColor = true;
            this.buttonAddAPIMethod.Click += new System.EventHandler(this.buttonAddAPIMethod_Click);
            // 
            // labelAPIMethods
            // 
            this.labelAPIMethods.AutoSize = true;
            this.labelAPIMethods.Location = new System.Drawing.Point(8, 6);
            this.labelAPIMethods.Name = "labelAPIMethods";
            this.labelAPIMethods.Size = new System.Drawing.Size(67, 13);
            this.labelAPIMethods.TabIndex = 1;
            this.labelAPIMethods.Text = "Методы API";
            // 
            // listBoxAPIMethods
            // 
            this.listBoxAPIMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAPIMethods.FormattingEnabled = true;
            this.listBoxAPIMethods.Location = new System.Drawing.Point(8, 48);
            this.listBoxAPIMethods.Name = "listBoxAPIMethods";
            this.listBoxAPIMethods.Size = new System.Drawing.Size(197, 368);
            this.listBoxAPIMethods.TabIndex = 0;
            this.listBoxAPIMethods.SelectedIndexChanged += new System.EventHandler(this.listBoxAPIMethods_SelectedIndexChanged);
            // 
            // tabKeys
            // 
            this.tabKeys.Controls.Add(this.keyAPIMethods);
            this.tabKeys.Controls.Add(this.buttonAddKey);
            this.tabKeys.Controls.Add(this.listBoxKeys);
            this.tabKeys.Location = new System.Drawing.Point(4, 22);
            this.tabKeys.Name = "tabKeys";
            this.tabKeys.Size = new System.Drawing.Size(797, 423);
            this.tabKeys.TabIndex = 2;
            this.tabKeys.Text = "Ключи доступа";
            this.tabKeys.UseVisualStyleBackColor = true;
            // 
            // keyAPIMethods
            // 
            this.keyAPIMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyAPIMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyAPIMethods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MethodName,
            this.TotalCount,
            this.SpentCount});
            this.keyAPIMethods.Location = new System.Drawing.Point(207, 45);
            this.keyAPIMethods.Name = "keyAPIMethods";
            this.keyAPIMethods.Size = new System.Drawing.Size(587, 368);
            this.keyAPIMethods.TabIndex = 2;
            // 
            // MethodName
            // 
            this.MethodName.HeaderText = "Метод API";
            this.MethodName.Name = "MethodName";
            this.MethodName.ReadOnly = true;
            // 
            // TotalCount
            // 
            this.TotalCount.HeaderText = "Общее количество запросов";
            this.TotalCount.Name = "TotalCount";
            // 
            // SpentCount
            // 
            this.SpentCount.HeaderText = "Истрачено запросов";
            this.SpentCount.Name = "SpentCount";
            // 
            // buttonAddKey
            // 
            this.buttonAddKey.Location = new System.Drawing.Point(8, 16);
            this.buttonAddKey.Name = "buttonAddKey";
            this.buttonAddKey.Size = new System.Drawing.Size(75, 23);
            this.buttonAddKey.TabIndex = 1;
            this.buttonAddKey.Text = "Добавить";
            this.buttonAddKey.UseVisualStyleBackColor = true;
            this.buttonAddKey.Click += new System.EventHandler(this.buttonAddKey_Click);
            // 
            // listBoxKeys
            // 
            this.listBoxKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxKeys.FormattingEnabled = true;
            this.listBoxKeys.Location = new System.Drawing.Point(8, 45);
            this.listBoxKeys.Name = "listBoxKeys";
            this.listBoxKeys.Size = new System.Drawing.Size(193, 368);
            this.listBoxKeys.TabIndex = 0;
            this.listBoxKeys.SelectedIndexChanged += new System.EventHandler(this.listBoxKeys_SelectedIndexChanged);
            // 
            // tabBaseSettings
            // 
            this.tabBaseSettings.Controls.Add(this.buttonRemoveDownloadKey);
            this.tabBaseSettings.Controls.Add(this.buttonAddDownloadKey);
            this.tabBaseSettings.Controls.Add(this.listBoxKeysList);
            this.tabBaseSettings.Controls.Add(this.labelKeysList);
            this.tabBaseSettings.Controls.Add(this.textBoxMockServerPort);
            this.tabBaseSettings.Controls.Add(this.labelMockServerPort);
            this.tabBaseSettings.Controls.Add(this.textBoxTemplateResourceString);
            this.tabBaseSettings.Controls.Add(this.labelTemplateResourceString);
            this.tabBaseSettings.Controls.Add(this.textBoxServerAPI);
            this.tabBaseSettings.Controls.Add(this.labelServerAPI);
            this.tabBaseSettings.Location = new System.Drawing.Point(4, 22);
            this.tabBaseSettings.Name = "tabBaseSettings";
            this.tabBaseSettings.Size = new System.Drawing.Size(797, 423);
            this.tabBaseSettings.TabIndex = 3;
            this.tabBaseSettings.Text = "Основные настройки";
            this.tabBaseSettings.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDownloadKey
            // 
            this.buttonRemoveDownloadKey.Location = new System.Drawing.Point(89, 160);
            this.buttonRemoveDownloadKey.Name = "buttonRemoveDownloadKey";
            this.buttonRemoveDownloadKey.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDownloadKey.TabIndex = 11;
            this.buttonRemoveDownloadKey.Text = "Удалить";
            this.buttonRemoveDownloadKey.UseVisualStyleBackColor = true;
            this.buttonRemoveDownloadKey.Click += new System.EventHandler(this.buttonRemoveDownloadKey_Click);
            // 
            // buttonAddDownloadKey
            // 
            this.buttonAddDownloadKey.Location = new System.Drawing.Point(8, 160);
            this.buttonAddDownloadKey.Name = "buttonAddDownloadKey";
            this.buttonAddDownloadKey.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDownloadKey.TabIndex = 10;
            this.buttonAddDownloadKey.Text = "Добавить";
            this.buttonAddDownloadKey.UseVisualStyleBackColor = true;
            this.buttonAddDownloadKey.Click += new System.EventHandler(this.buttonAddDownloadKey_Click);
            // 
            // listBoxKeysList
            // 
            this.listBoxKeysList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxKeysList.FormattingEnabled = true;
            this.listBoxKeysList.Location = new System.Drawing.Point(8, 186);
            this.listBoxKeysList.Name = "listBoxKeysList";
            this.listBoxKeysList.Size = new System.Drawing.Size(298, 225);
            this.listBoxKeysList.TabIndex = 9;
            // 
            // labelKeysList
            // 
            this.labelKeysList.AutoSize = true;
            this.labelKeysList.Location = new System.Drawing.Point(8, 144);
            this.labelKeysList.Name = "labelKeysList";
            this.labelKeysList.Size = new System.Drawing.Size(273, 13);
            this.labelKeysList.TabIndex = 8;
            this.labelKeysList.Text = "Список ключей доступа для загрузки данныз из API";
            // 
            // textBoxMockServerPort
            // 
            this.textBoxMockServerPort.Location = new System.Drawing.Point(11, 102);
            this.textBoxMockServerPort.MaxLength = 5;
            this.textBoxMockServerPort.Name = "textBoxMockServerPort";
            this.textBoxMockServerPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxMockServerPort.TabIndex = 7;
            this.textBoxMockServerPort.TextChanged += new System.EventHandler(this.textBoxMockServerPort_TextChanged);
            // 
            // labelMockServerPort
            // 
            this.labelMockServerPort.AutoSize = true;
            this.labelMockServerPort.Location = new System.Drawing.Point(8, 86);
            this.labelMockServerPort.Name = "labelMockServerPort";
            this.labelMockServerPort.Size = new System.Drawing.Size(106, 13);
            this.labelMockServerPort.TabIndex = 6;
            this.labelMockServerPort.Text = "Порт mock-сервера";
            // 
            // textBoxTemplateResourceString
            // 
            this.textBoxTemplateResourceString.Location = new System.Drawing.Point(8, 63);
            this.textBoxTemplateResourceString.Name = "textBoxTemplateResourceString";
            this.textBoxTemplateResourceString.Size = new System.Drawing.Size(776, 20);
            this.textBoxTemplateResourceString.TabIndex = 5;
            this.textBoxTemplateResourceString.TextChanged += new System.EventHandler(this.textBoxTemplateResourceString_TextChanged);
            // 
            // labelTemplateResourceString
            // 
            this.labelTemplateResourceString.AutoSize = true;
            this.labelTemplateResourceString.Location = new System.Drawing.Point(8, 47);
            this.labelTemplateResourceString.Name = "labelTemplateResourceString";
            this.labelTemplateResourceString.Size = new System.Drawing.Size(426, 13);
            this.labelTemplateResourceString.TabIndex = 4;
            this.labelTemplateResourceString.Text = "Шаблон строки запроса (например /api/{APIMethod}?par1={Key1}&par2={DataValue})";
            // 
            // textBoxServerAPI
            // 
            this.textBoxServerAPI.Location = new System.Drawing.Point(11, 24);
            this.textBoxServerAPI.Name = "textBoxServerAPI";
            this.textBoxServerAPI.Size = new System.Drawing.Size(773, 20);
            this.textBoxServerAPI.TabIndex = 3;
            this.textBoxServerAPI.TextChanged += new System.EventHandler(this.textBoxServerAPI_TextChanged);
            // 
            // labelServerAPI
            // 
            this.labelServerAPI.AutoSize = true;
            this.labelServerAPI.Location = new System.Drawing.Point(8, 8);
            this.labelServerAPI.Name = "labelServerAPI";
            this.labelServerAPI.Size = new System.Drawing.Size(64, 13);
            this.labelServerAPI.TabIndex = 2;
            this.labelServerAPI.Text = "Сервер API";
            // 
            // textBoxDataContent
            // 
            this.textBoxDataContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataContent.Location = new System.Drawing.Point(560, 58);
            this.textBoxDataContent.Multiline = true;
            this.textBoxDataContent.Name = "textBoxDataContent";
            this.textBoxDataContent.Size = new System.Drawing.Size(231, 349);
            this.textBoxDataContent.TabIndex = 7;
            // 
            // buttonLoadDataFromAPI
            // 
            this.buttonLoadDataFromAPI.Location = new System.Drawing.Point(192, 29);
            this.buttonLoadDataFromAPI.Name = "buttonLoadDataFromAPI";
            this.buttonLoadDataFromAPI.Size = new System.Drawing.Size(152, 23);
            this.buttonLoadDataFromAPI.TabIndex = 8;
            this.buttonLoadDataFromAPI.Text = "Загрузить данные из API";
            this.buttonLoadDataFromAPI.UseVisualStyleBackColor = true;
            this.buttonLoadDataFromAPI.Click += new System.EventHandler(this.buttonLoadDataFromAPI_Click);
            // 
            // FormAPIData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAPIData";
            this.Text = "Данные API";
            this.tabControl1.ResumeLayout(false);
            this.tabAPIData.ResumeLayout(false);
            this.tabAPIData.PerformLayout();
            this.tabMethodsSettings.ResumeLayout(false);
            this.tabMethodsSettings.PerformLayout();
            this.panelAPIMethodInfo.ResumeLayout(false);
            this.panelAPIMethodInfo.PerformLayout();
            this.tabKeys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyAPIMethods)).EndInit();
            this.tabBaseSettings.ResumeLayout(false);
            this.tabBaseSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAPIData;
        private System.Windows.Forms.TabPage tabMethodsSettings;
        private System.Windows.Forms.Label labelAPIMethods;
        private System.Windows.Forms.ListBox listBoxAPIMethods;
        private System.Windows.Forms.Button buttonAddAPIMethod;
        private System.Windows.Forms.Panel panelAPIMethodInfo;
        private System.Windows.Forms.CheckBox checkBoxDownloadAllow;
        private System.Windows.Forms.TextBox textBoxResourceString;
        private System.Windows.Forms.Label labelResourceString;
        private System.Windows.Forms.Button buttonDeleteAPIMethod;
        private System.Windows.Forms.TabPage tabKeys;
        private System.Windows.Forms.TabPage tabBaseSettings;
        private System.Windows.Forms.Label labelServerAPI;
        private System.Windows.Forms.TextBox textBoxServerAPI;
        private System.Windows.Forms.TextBox textBoxTemplateResourceString;
        private System.Windows.Forms.Label labelTemplateResourceString;
        private System.Windows.Forms.Label labelMockServerPort;
        private System.Windows.Forms.ListBox listBoxKeys;
        private System.Windows.Forms.Button buttonAddKey;
        private System.Windows.Forms.DataGridView keyAPIMethods;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpentCount;
        private System.Windows.Forms.TextBox textBoxMockServerPort;
        private System.Windows.Forms.Label labelKeysList;
        private System.Windows.Forms.ListBox listBoxKeysList;
        private System.Windows.Forms.Button buttonAddDownloadKey;
        private System.Windows.Forms.Button buttonRemoveDownloadKey;
        private System.Windows.Forms.Label labelDataList;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.CheckedListBox checkedListBoxData;
        private System.Windows.Forms.ListBox listBoxDataMethods;
        private System.Windows.Forms.Button buttonRemoveData;
        private System.Windows.Forms.Label labelDataMethods;
        private System.Windows.Forms.TextBox textBoxDataContent;
        private System.Windows.Forms.Button buttonLoadDataFromAPI;
    }
}

