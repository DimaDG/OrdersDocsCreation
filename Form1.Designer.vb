<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbTowns = New System.Windows.Forms.ComboBox()
        Me.MedEstTownsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERS_DataSet = New ORDERS_VER_2.ORDERS_DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbHospitals = New System.Windows.Forms.ListBox()
        Me.MedEstTownsListMedEstByTownsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbLettersList = New System.Windows.Forms.TextBox()
        Me.tbComplList = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkLBTasks = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbScope = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkLBOrderType = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerTill = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbAHIFs = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbRHIFs = New System.Windows.Forms.ComboBox()
        Me.tbTownType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEditHospitalList = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHospType = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbDirections = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTeamList = New System.Windows.Forms.ListBox()
        Me.cbTeamHead = New System.Windows.Forms.ComboBox()
        Me.StaffListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnSelectionClean = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.chkBStandards = New System.Windows.Forms.CheckedListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.MedEst_Towns_ListTableAdapter = New ORDERS_VER_2.ORDERS_DataSetTableAdapters.MedEst_Towns_ListTableAdapter()
        Me.MedEst_By_TownsTableAdapter = New ORDERS_VER_2.ORDERS_DataSetTableAdapters.MedEst_By_TownsTableAdapter()
        Me.Staff_ListTableAdapter = New ORDERS_VER_2.ORDERS_DataSetTableAdapters.Staff_ListTableAdapter()
        CType(Me.MedEstTownsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedEstTownsListMedEstByTownsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.StaffListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTowns
        '
        Me.cbTowns.DataSource = Me.MedEstTownsListBindingSource
        Me.cbTowns.DisplayMember = "Town_name"
        Me.cbTowns.FormattingEnabled = True
        Me.cbTowns.Location = New System.Drawing.Point(217, 7)
        Me.cbTowns.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTowns.Name = "cbTowns"
        Me.cbTowns.Size = New System.Drawing.Size(320, 24)
        Me.cbTowns.TabIndex = 0
        '
        'MedEstTownsListBindingSource
        '
        Me.MedEstTownsListBindingSource.DataMember = "MedEst_Towns_List"
        Me.MedEstTownsListBindingSource.DataSource = Me.ORDERS_DataSet
        '
        'ORDERS_DataSet
        '
        Me.ORDERS_DataSet.DataSetName = "ORDERS_DataSet"
        Me.ORDERS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Населено място:"
        '
        'lbHospitals
        '
        Me.lbHospitals.DataSource = Me.MedEstTownsListMedEstByTownsBindingSource
        Me.lbHospitals.DisplayMember = "MedEst_Name"
        Me.lbHospitals.FormattingEnabled = True
        Me.lbHospitals.ItemHeight = 16
        Me.lbHospitals.Location = New System.Drawing.Point(217, 64)
        Me.lbHospitals.Margin = New System.Windows.Forms.Padding(4)
        Me.lbHospitals.Name = "lbHospitals"
        Me.lbHospitals.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbHospitals.Size = New System.Drawing.Size(497, 180)
        Me.lbHospitals.Sorted = True
        Me.lbHospitals.TabIndex = 2
        '
        'MedEstTownsListMedEstByTownsBindingSource
        '
        Me.MedEstTownsListMedEstByTownsBindingSource.DataMember = "MedEst_Towns_List_MedEst_By_Towns"
        Me.MedEstTownsListMedEstByTownsBindingSource.DataSource = Me.MedEstTownsListBindingSource
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Лечебно заведение:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(921, 463)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.tbLettersList)
        Me.TabPage3.Controls.Add(Me.tbComplList)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.chkLBTasks)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.lbScope)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.chkLBOrderType)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.DateTimePickerTill)
        Me.TabPage3.Controls.Add(Me.DateTimePickerFrom)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(913, 434)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Заповед"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(531, 215)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Списък писма"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(531, 154)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Списък жалби"
        Me.Label12.Visible = False
        '
        'tbLettersList
        '
        Me.tbLettersList.AllowDrop = True
        Me.tbLettersList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbLettersList.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLettersList.Location = New System.Drawing.Point(531, 235)
        Me.tbLettersList.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLettersList.Name = "tbLettersList"
        Me.tbLettersList.Size = New System.Drawing.Size(372, 22)
        Me.tbLettersList.TabIndex = 11
        Me.tbLettersList.Visible = False
        '
        'tbComplList
        '
        Me.tbComplList.AllowDrop = True
        Me.tbComplList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbComplList.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbComplList.Location = New System.Drawing.Point(531, 177)
        Me.tbComplList.Margin = New System.Windows.Forms.Padding(4)
        Me.tbComplList.Name = "tbComplList"
        Me.tbComplList.Size = New System.Drawing.Size(372, 22)
        Me.tbComplList.TabIndex = 10
        Me.tbComplList.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 165)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Задачи на проверката:"
        '
        'chkLBTasks
        '
        Me.chkLBTasks.CheckOnClick = True
        Me.chkLBTasks.FormattingEnabled = True
        Me.chkLBTasks.Items.AddRange(New Object() {"Проверка по жалба", "Проверка по писмо", "Структура, организация и дейност", "Проверка по медицински стандарти", "По Наредбата за достъп /НОПДМП/", "По Наредба №34", "Проверка на РЗОК", "Проверка на НЗОК (централно управление)", "Проверка на ДЗОФ"})
        Me.chkLBTasks.Location = New System.Drawing.Point(179, 165)
        Me.chkLBTasks.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLBTasks.Name = "chkLBTasks"
        Me.chkLBTasks.Size = New System.Drawing.Size(331, 174)
        Me.chkLBTasks.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(530, 63)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Обхват:"
        '
        'lbScope
        '
        Me.lbScope.FormattingEnabled = True
        Me.lbScope.ItemHeight = 16
        Me.lbScope.Items.AddRange(New Object() {"едно ЛЗ", "проследяване на случай"})
        Me.lbScope.Location = New System.Drawing.Point(606, 63)
        Me.lbScope.Margin = New System.Windows.Forms.Padding(4)
        Me.lbScope.Name = "lbScope"
        Me.lbScope.Size = New System.Drawing.Size(189, 52)
        Me.lbScope.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 63)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Вид на проверката:"
        '
        'chkLBOrderType
        '
        Me.chkLBOrderType.CheckOnClick = True
        Me.chkLBOrderType.FormattingEnabled = True
        Me.chkLBOrderType.Items.AddRange(New Object() {"ИЗВЪНРЕДНА", "ИЗВЪНРЕДНА (след самосезиране)", "ПЛАНОВА", "ТЕМАТИЧНА"})
        Me.chkLBOrderType.Location = New System.Drawing.Point(179, 63)
        Me.chkLBOrderType.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLBOrderType.Name = "chkLBOrderType"
        Me.chkLBOrderType.Size = New System.Drawing.Size(331, 72)
        Me.chkLBOrderType.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "до:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Период на проверката от:"
        '
        'DateTimePickerTill
        '
        Me.DateTimePickerTill.Location = New System.Drawing.Point(564, 17)
        Me.DateTimePickerTill.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerTill.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerTill.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerTill.Name = "DateTimePickerTill"
        Me.DateTimePickerTill.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerTill.TabIndex = 1
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(249, 17)
        Me.DateTimePickerFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerFrom.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerFrom.TabIndex = 0
        Me.DateTimePickerFrom.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.cbAHIFs)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.cbRHIFs)
        Me.TabPage1.Controls.Add(Me.tbTownType)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.btnEditHospitalList)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tbHospType)
        Me.TabPage1.Controls.Add(Me.cbTowns)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lbHospitals)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(913, 434)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Обект"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(516, 358)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "ДЗОФ:"
        '
        'cbAHIFs
        '
        Me.cbAHIFs.FormattingEnabled = True
        Me.cbAHIFs.Items.AddRange(New Object() {"FiHealth", "Булстрад Здраве", "България Здраве", "Вайс Медика", "Всеотдайност", "ДаллБогг", "Дженерали", "ДЗИ Здравно осигуряване", "Доверие", "Евроинс Здравно осигуряване", "Здравноосигурителен институт", "Медико 21", "Надежда", "Планета", "Токуда", "ЦКБ Здраве", "Юнайтед Медикал"})
        Me.cbAHIFs.Location = New System.Drawing.Point(584, 353)
        Me.cbAHIFs.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAHIFs.Name = "cbAHIFs"
        Me.cbAHIFs.Size = New System.Drawing.Size(268, 24)
        Me.cbAHIFs.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(149, 357)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "РЗОК:"
        '
        'cbRHIFs
        '
        Me.cbRHIFs.FormattingEnabled = True
        Me.cbRHIFs.Items.AddRange(New Object() {"Благоевград", "Бургас", "Варна", "Велико Търново", "Видин", "Враца", "Габрово", "Добрич", "Кърджали", "Кюстендил", "Ловеч", "Монтана", "Пазарджик", "Перник", "Плевен", "Пловдив", "Разград", "Русе", "Силистра", "Сливен", "Смолян", "София - Град", "София - Област", "Стара Загора", "Търговище", "Хасково", "Шумен", "Ямбол"})
        Me.cbRHIFs.Location = New System.Drawing.Point(217, 353)
        Me.cbRHIFs.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRHIFs.Name = "cbRHIFs"
        Me.cbRHIFs.Size = New System.Drawing.Size(268, 24)
        Me.cbRHIFs.TabIndex = 10
        '
        'tbTownType
        '
        Me.tbTownType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedEstTownsListMedEstByTownsBindingSource, "Town_type", True))
        Me.tbTownType.Location = New System.Drawing.Point(547, 7)
        Me.tbTownType.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTownType.Name = "tbTownType"
        Me.tbTownType.Size = New System.Drawing.Size(65, 22)
        Me.tbTownType.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 265)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Адрес:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedEstTownsListMedEstByTownsBindingSource, "Address", True))
        Me.TextBox1.Location = New System.Drawing.Point(217, 265)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(497, 22)
        Me.TextBox1.TabIndex = 7
        '
        'btnEditHospitalList
        '
        Me.btnEditHospitalList.BackColor = System.Drawing.Color.Yellow
        Me.btnEditHospitalList.Location = New System.Drawing.Point(8, 202)
        Me.btnEditHospitalList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditHospitalList.Name = "btnEditHospitalList"
        Me.btnEditHospitalList.Size = New System.Drawing.Size(192, 42)
        Me.btnEditHospitalList.TabIndex = 6
        Me.btnEditHospitalList.Text = "редактиране на списъка"
        Me.btnEditHospitalList.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(777, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "вид"
        '
        'tbHospType
        '
        Me.tbHospType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedEstTownsListMedEstByTownsBindingSource, "Type_Name_short", True))
        Me.tbHospType.Location = New System.Drawing.Point(732, 64)
        Me.tbHospType.Margin = New System.Windows.Forms.Padding(4)
        Me.tbHospType.Name = "tbHospType"
        Me.tbHospType.Size = New System.Drawing.Size(132, 22)
        Me.tbHospType.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.lbDirections)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.lbTeamList)
        Me.TabPage2.Controls.Add(Me.cbTeamHead)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(913, 434)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Комисия"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(684, 50)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(168, 17)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "филтър на служителите"
        '
        'lbDirections
        '
        Me.lbDirections.FormattingEnabled = True
        Me.lbDirections.ItemHeight = 16
        Me.lbDirections.Items.AddRange(New Object() {"всички дирекции", "АПФИО", "ИАМО", "КМОЛЗ", "ОППП", "ОКА"})
        Me.lbDirections.Location = New System.Drawing.Point(684, 73)
        Me.lbDirections.Margin = New System.Windows.Forms.Padding(4)
        Me.lbDirections.Name = "lbDirections"
        Me.lbDirections.Size = New System.Drawing.Size(169, 100)
        Me.lbDirections.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Членове на комисията:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Председател на комисията:"
        '
        'lbTeamList
        '
        Me.lbTeamList.FormattingEnabled = True
        Me.lbTeamList.ItemHeight = 16
        Me.lbTeamList.Location = New System.Drawing.Point(225, 73)
        Me.lbTeamList.Margin = New System.Windows.Forms.Padding(4)
        Me.lbTeamList.Name = "lbTeamList"
        Me.lbTeamList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbTeamList.Size = New System.Drawing.Size(451, 340)
        Me.lbTeamList.TabIndex = 1
        '
        'cbTeamHead
        '
        Me.cbTeamHead.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StaffListBindingSource, "NamesOrderDoc", True))
        Me.cbTeamHead.DataSource = Me.StaffListBindingSource
        Me.cbTeamHead.DisplayMember = "NamesListBox"
        Me.cbTeamHead.FormattingEnabled = True
        Me.cbTeamHead.Location = New System.Drawing.Point(225, 18)
        Me.cbTeamHead.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTeamHead.Name = "cbTeamHead"
        Me.cbTeamHead.Size = New System.Drawing.Size(452, 24)
        Me.cbTeamHead.TabIndex = 0
        '
        'StaffListBindingSource
        '
        Me.StaffListBindingSource.DataMember = "Staff_List"
        Me.StaffListBindingSource.DataSource = Me.ORDERS_DataSet
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnSelectionClean)
        Me.TabPage4.Controls.Add(Me.btnSelectAll)
        Me.TabPage4.Controls.Add(Me.chkBStandards)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(913, 434)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Стандарти"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnSelectionClean
        '
        Me.btnSelectionClean.BackColor = System.Drawing.Color.Red
        Me.btnSelectionClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSelectionClean.Location = New System.Drawing.Point(728, 75)
        Me.btnSelectionClean.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectionClean.Name = "btnSelectionClean"
        Me.btnSelectionClean.Size = New System.Drawing.Size(175, 28)
        Me.btnSelectionClean.TabIndex = 2
        Me.btnSelectionClean.Text = "изчистване на избора"
        Me.btnSelectionClean.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.Blue
        Me.btnSelectAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSelectAll.Location = New System.Drawing.Point(728, 23)
        Me.btnSelectAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(175, 28)
        Me.btnSelectAll.TabIndex = 1
        Me.btnSelectAll.Text = "избор на всички"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'chkBStandards
        '
        Me.chkBStandards.CheckOnClick = True
        Me.chkBStandards.FormattingEnabled = True
        Me.chkBStandards.Items.AddRange(New Object() {"АКУШЕРСТВО И ГИНЕКОЛОГИЯ", "АНЕСТЕЗИЯ И ИНТЕНЗИВНО ЛЕЧЕНИЕ", "АСИСТИРАНА РЕПРОДУКЦИЯ", "ВИРУСОЛОГИЯ", "ВЪТРЕШНИ БОЛЕСТИ", "ГАСТРОЕНТЕРОЛОГИЯ", "ГРЪДНА ХИРУРГИЯ", "ДЕТСКА ДЕНТАЛНА МЕДИЦИНА", "ДИАЛИЗНО ЛЕЧЕНИЕ", "ЕНДОКРИНОЛОГИЯ И БОЛЕСТИ НА ОБМЯНАТА", "ИМУНОЛОГИЧНА ПОДГОТОВКА ПРИ ТРАНСПЛАНТАЦИЯ НА ОРГАНИ, ТЪКАНИ И КЛЕТКИ", "ИНФЕКЦИОЗНИ БОЛЕСТИ", "КАРДИОЛОГИЯ", "КАРДИОХИРУРГИЯ", "КЛИНИЧНА АЛЕРГОЛОГИЯ", "КЛИНИЧНА ИМУНОЛОГИЯ", "КЛИНИЧНА ЛАБОРАТОРИЯ", "КЛИНИЧНА ПАТОЛОГИЯ", "КЛИНИЧНА ТОКСИКОЛОГИЯ", "КЛИНИЧНА ХЕМАТОЛОГИЯ", "КОЖНИ И ВЕНЕРИЧЕСКИ БОЛЕСТИ", "ЛИЦЕВО-ЧЕЛЮСТНА ХИРУРГИЯ", "ЛЪЧЕЛЕЧЕНИЕ", "МЕДИКО-ТЕХНИЧЕСКИ СТАНДАРТ ПО ЗЪБОТЕХНИКА", "МЕДИЦИНСКА ГЕНЕТИКА", "МЕДИЦИНСКА ОНКОЛОГИЯ", "МЕДИЦИНСКА ПАРАЗИТОЛОГИЯ", "МИКРОБИОЛОГИЯ", "НЕВРОХИРУРГИЯ", "НЕОНАТОЛОГИЯ", "НЕРВНИ БОЛЕСТИ", "НЕФРОЛОГИЯ", "НУКЛЕАРНА МЕДИЦИНА", "ОБРАЗНА ДИАГНОСТИКА", "ОБЩА МЕДИЦИНСКА ПРАКТИКА", "ОБЩИ МЕДИЦИНСКИ СТАНДАРТИ ПО ХИРУРГИЯ", "ОРАЛНА ХИРУРГИЯ", "ОРТОДОНТИЯ", "ОРТОПЕДИЯ И ТРАВМАТОЛОГИЯ", "ОЧНИ БОЛЕСТИ", "ПЕДИАТРИЯ", "ПЛАСТИЧНО-ВЪЗСТАНОВИТЕЛНА И ЕСТЕТИЧНА ХИРУРГИЯ", "ПНЕВМОЛОГИЯ И ФТИЗИАТРИЯ", "ПРЕВЕНЦИЯ И КОНТРОЛ НА ВЪТРЕБОЛНИЧНИТЕ ИНФЕКЦИИ", "ПРОФЕСИОНАЛНИ БОЛЕСТИ", "ПСИХИАТРИЯ", "РЕВМАТОЛОГИЯ", "СПЕШНА МЕДИЦИНА", "ТРАНСФУЗИОННА ХЕМАТОЛОГИЯ", "УРОЛОГИЯ", "УШНО-НОСНО-ГЪРЛЕНИ БОЛЕСТИ", "ФИЗИКАЛНА И РЕХАБИЛИТАЦИОННА МЕДИЦИНА"})
        Me.chkBStandards.Location = New System.Drawing.Point(21, 23)
        Me.chkBStandards.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBStandards.Name = "chkBStandards"
        Me.chkBStandards.Size = New System.Drawing.Size(699, 378)
        Me.chkBStandards.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(821, 475)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 49)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Lime
        Me.btnOK.Location = New System.Drawing.Point(8, 475)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 49)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'MedEst_Towns_ListTableAdapter
        '
        Me.MedEst_Towns_ListTableAdapter.ClearBeforeFill = True
        '
        'MedEst_By_TownsTableAdapter
        '
        Me.MedEst_By_TownsTableAdapter.ClearBeforeFill = True
        '
        'Staff_ListTableAdapter
        '
        Me.Staff_ListTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(925, 545)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Изготване на заповед за проверка"
        CType(Me.MedEstTownsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedEstTownsListMedEstByTownsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.StaffListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbTowns As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbHospitals As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents tbHospType As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnEditHospitalList As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbTownType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTeamList As ListBox
    Friend WithEvents cbTeamHead As ComboBox
    Friend WithEvents lbDirections As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePickerTill As DateTimePicker
    Friend WithEvents DateTimePickerFrom As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents chkLBOrderType As CheckedListBox
    Friend WithEvents lbScope As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents chkLBTasks As CheckedListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbLettersList As TextBox
    Friend WithEvents tbComplList As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnSelectionClean As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents chkBStandards As CheckedListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbAHIFs As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbRHIFs As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ORDERS_DataSet As ORDERS_DataSet
    Friend WithEvents MedEstTownsListBindingSource As BindingSource
    Friend WithEvents MedEst_Towns_ListTableAdapter As ORDERS_DataSetTableAdapters.MedEst_Towns_ListTableAdapter
    Friend WithEvents MedEstTownsListMedEstByTownsBindingSource As BindingSource
    Friend WithEvents MedEst_By_TownsTableAdapter As ORDERS_DataSetTableAdapters.MedEst_By_TownsTableAdapter
    Friend WithEvents StaffListBindingSource As BindingSource
    Friend WithEvents Staff_ListTableAdapter As ORDERS_DataSetTableAdapters.Staff_ListTableAdapter
End Class
