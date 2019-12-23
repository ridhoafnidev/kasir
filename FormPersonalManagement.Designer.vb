<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPersonalManagement
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Kode_barangLabel As System.Windows.Forms.Label
        Dim Kode_jenisLabel As System.Windows.Forms.Label
        Dim Nama_barangLabel As System.Windows.Forms.Label
        Dim Kode_merkLabel As System.Windows.Forms.Label
        Dim Harga_jualLabel As System.Windows.Forms.Label
        Dim Harga_beliLabel As System.Windows.Forms.Label
        Dim Stok_barangLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Dim Kode_satuanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPersonalManagement))
        Me.DbPenjualanDataSet = New AplikasiKasirPenjualan.DbPenjualanDataSet()
        Me.Tb_barangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_barangTableAdapter = New AplikasiKasirPenjualan.DbPenjualanDataSetTableAdapters.tb_barangTableAdapter()
        Me.TableAdapterManager = New AplikasiKasirPenjualan.DbPenjualanDataSetTableAdapters.TableAdapterManager()
        Me.Tb_barangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_barangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Kode_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_jenisTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_merkTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_jualTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_beliTextBox = New System.Windows.Forms.TextBox()
        Me.Stok_barangTextBox = New System.Windows.Forms.TextBox()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_satuanTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_barangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonHapusBarang = New System.Windows.Forms.Button()
        Me.ButtonKeluarBarang = New System.Windows.Forms.Button()
        Me.ButtonCariBarang = New System.Windows.Forms.Button()
        Me.KeywordTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSimpanBarang = New System.Windows.Forms.Button()
        Me.ButtonTambahBarang = New System.Windows.Forms.Button()
        Kode_barangLabel = New System.Windows.Forms.Label()
        Kode_jenisLabel = New System.Windows.Forms.Label()
        Nama_barangLabel = New System.Windows.Forms.Label()
        Kode_merkLabel = New System.Windows.Forms.Label()
        Harga_jualLabel = New System.Windows.Forms.Label()
        Harga_beliLabel = New System.Windows.Forms.Label()
        Stok_barangLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        Kode_satuanLabel = New System.Windows.Forms.Label()
        CType(Me.DbPenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_barangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_barangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_barangBindingNavigator.SuspendLayout()
        CType(Me.Tb_barangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Kode_barangLabel
        '
        Kode_barangLabel.AutoSize = True
        Kode_barangLabel.Location = New System.Drawing.Point(32, 80)
        Kode_barangLabel.Name = "Kode_barangLabel"
        Kode_barangLabel.Size = New System.Drawing.Size(72, 13)
        Kode_barangLabel.TabIndex = 1
        Kode_barangLabel.Text = "Kode Barang:"
        '
        'Kode_jenisLabel
        '
        Kode_jenisLabel.AutoSize = True
        Kode_jenisLabel.Location = New System.Drawing.Point(32, 131)
        Kode_jenisLabel.Name = "Kode_jenisLabel"
        Kode_jenisLabel.Size = New System.Drawing.Size(71, 13)
        Kode_jenisLabel.TabIndex = 3
        Kode_jenisLabel.Text = "Jenis Barang:"
        '
        'Nama_barangLabel
        '
        Nama_barangLabel.AutoSize = True
        Nama_barangLabel.Location = New System.Drawing.Point(32, 105)
        Nama_barangLabel.Name = "Nama_barangLabel"
        Nama_barangLabel.Size = New System.Drawing.Size(75, 13)
        Nama_barangLabel.TabIndex = 5
        Nama_barangLabel.Text = "Nama Barang:"
        '
        'Kode_merkLabel
        '
        Kode_merkLabel.AutoSize = True
        Kode_merkLabel.Location = New System.Drawing.Point(32, 158)
        Kode_merkLabel.Name = "Kode_merkLabel"
        Kode_merkLabel.Size = New System.Drawing.Size(71, 13)
        Kode_merkLabel.TabIndex = 7
        Kode_merkLabel.Text = "Merk Barang:"
        '
        'Harga_jualLabel
        '
        Harga_jualLabel.AutoSize = True
        Harga_jualLabel.Location = New System.Drawing.Point(12, 58)
        Harga_jualLabel.Name = "Harga_jualLabel"
        Harga_jualLabel.Size = New System.Drawing.Size(61, 13)
        Harga_jualLabel.TabIndex = 9
        Harga_jualLabel.Text = "Harga Jual:"
        '
        'Harga_beliLabel
        '
        Harga_beliLabel.AutoSize = True
        Harga_beliLabel.Location = New System.Drawing.Point(12, 31)
        Harga_beliLabel.Name = "Harga_beliLabel"
        Harga_beliLabel.Size = New System.Drawing.Size(59, 13)
        Harga_beliLabel.TabIndex = 11
        Harga_beliLabel.Text = "Harga Beli:"
        '
        'Stok_barangLabel
        '
        Stok_barangLabel.AutoSize = True
        Stok_barangLabel.Location = New System.Drawing.Point(391, 133)
        Stok_barangLabel.Name = "Stok_barangLabel"
        Stok_barangLabel.Size = New System.Drawing.Size(69, 13)
        Stok_barangLabel.TabIndex = 13
        Stok_barangLabel.Text = "Stok Barang:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(391, 185)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(64, 13)
        KeteranganLabel.TabIndex = 15
        KeteranganLabel.Text = "keterangan:"
        '
        'Kode_satuanLabel
        '
        Kode_satuanLabel.AutoSize = True
        Kode_satuanLabel.Location = New System.Drawing.Point(391, 159)
        Kode_satuanLabel.Name = "Kode_satuanLabel"
        Kode_satuanLabel.Size = New System.Drawing.Size(44, 13)
        Kode_satuanLabel.TabIndex = 17
        Kode_satuanLabel.Text = "Satuan:"
        '
        'DbPenjualanDataSet
        '
        Me.DbPenjualanDataSet.DataSetName = "DbPenjualanDataSet"
        Me.DbPenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_barangBindingSource
        '
        Me.Tb_barangBindingSource.DataMember = "tb_barang"
        Me.Tb_barangBindingSource.DataSource = Me.DbPenjualanDataSet
        '
        'Tb_barangTableAdapter
        '
        Me.Tb_barangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_barangTableAdapter = Me.Tb_barangTableAdapter
        Me.TableAdapterManager.tb_detail_penjualanTableAdapter = Nothing
        Me.TableAdapterManager.tb_jenisTableAdapter = Nothing
        Me.TableAdapterManager.tb_merkTableAdapter = Nothing
        Me.TableAdapterManager.tb_penggunaTableAdapter = Nothing
        Me.TableAdapterManager.tb_penjualanTableAdapter = Nothing
        Me.TableAdapterManager.tb_satuanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AplikasiKasirPenjualan.DbPenjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_barangBindingNavigator
        '
        Me.Tb_barangBindingNavigator.AddNewItem = Nothing
        Me.Tb_barangBindingNavigator.BindingSource = Me.Tb_barangBindingSource
        Me.Tb_barangBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_barangBindingNavigator.DeleteItem = Nothing
        Me.Tb_barangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_barangBindingNavigatorSaveItem})
        Me.Tb_barangBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_barangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_barangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_barangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_barangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_barangBindingNavigator.Name = "Tb_barangBindingNavigator"
        Me.Tb_barangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_barangBindingNavigator.Size = New System.Drawing.Size(974, 25)
        Me.Tb_barangBindingNavigator.TabIndex = 0
        Me.Tb_barangBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tb_barangBindingNavigatorSaveItem
        '
        Me.Tb_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_barangBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_barangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_barangBindingNavigatorSaveItem.Name = "Tb_barangBindingNavigatorSaveItem"
        Me.Tb_barangBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_barangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Kode_barangTextBox
        '
        Me.Kode_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "kode_barang", True))
        Me.Kode_barangTextBox.Location = New System.Drawing.Point(109, 78)
        Me.Kode_barangTextBox.Name = "Kode_barangTextBox"
        Me.Kode_barangTextBox.Size = New System.Drawing.Size(132, 20)
        Me.Kode_barangTextBox.TabIndex = 2
        '
        'Kode_jenisTextBox
        '
        Me.Kode_jenisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "kode_jenis", True))
        Me.Kode_jenisTextBox.Location = New System.Drawing.Point(109, 129)
        Me.Kode_jenisTextBox.Name = "Kode_jenisTextBox"
        Me.Kode_jenisTextBox.Size = New System.Drawing.Size(132, 20)
        Me.Kode_jenisTextBox.TabIndex = 4
        '
        'Nama_barangTextBox
        '
        Me.Nama_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "nama_barang", True))
        Me.Nama_barangTextBox.Location = New System.Drawing.Point(109, 103)
        Me.Nama_barangTextBox.Name = "Nama_barangTextBox"
        Me.Nama_barangTextBox.Size = New System.Drawing.Size(132, 20)
        Me.Nama_barangTextBox.TabIndex = 6
        '
        'Kode_merkTextBox
        '
        Me.Kode_merkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "kode_merk", True))
        Me.Kode_merkTextBox.Location = New System.Drawing.Point(109, 156)
        Me.Kode_merkTextBox.Name = "Kode_merkTextBox"
        Me.Kode_merkTextBox.Size = New System.Drawing.Size(242, 20)
        Me.Kode_merkTextBox.TabIndex = 8
        '
        'Harga_jualTextBox
        '
        Me.Harga_jualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "harga_jual", True))
        Me.Harga_jualTextBox.Location = New System.Drawing.Point(104, 55)
        Me.Harga_jualTextBox.Name = "Harga_jualTextBox"
        Me.Harga_jualTextBox.Size = New System.Drawing.Size(246, 20)
        Me.Harga_jualTextBox.TabIndex = 10
        '
        'Harga_beliTextBox
        '
        Me.Harga_beliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "harga_beli", True))
        Me.Harga_beliTextBox.Location = New System.Drawing.Point(104, 28)
        Me.Harga_beliTextBox.Name = "Harga_beliTextBox"
        Me.Harga_beliTextBox.Size = New System.Drawing.Size(246, 20)
        Me.Harga_beliTextBox.TabIndex = 12
        '
        'Stok_barangTextBox
        '
        Me.Stok_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "stok_barang", True))
        Me.Stok_barangTextBox.Location = New System.Drawing.Point(483, 130)
        Me.Stok_barangTextBox.Name = "Stok_barangTextBox"
        Me.Stok_barangTextBox.Size = New System.Drawing.Size(246, 20)
        Me.Stok_barangTextBox.TabIndex = 14
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(483, 182)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(246, 20)
        Me.KeteranganTextBox.TabIndex = 16
        '
        'Kode_satuanTextBox
        '
        Me.Kode_satuanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_barangBindingSource, "kode_satuan", True))
        Me.Kode_satuanTextBox.Location = New System.Drawing.Point(483, 156)
        Me.Kode_satuanTextBox.Name = "Kode_satuanTextBox"
        Me.Kode_satuanTextBox.Size = New System.Drawing.Size(246, 20)
        Me.Kode_satuanTextBox.TabIndex = 18
        '
        'Tb_barangDataGridView
        '
        Me.Tb_barangDataGridView.AllowUserToAddRows = False
        Me.Tb_barangDataGridView.AllowUserToDeleteRows = False
        Me.Tb_barangDataGridView.AutoGenerateColumns = False
        Me.Tb_barangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_barangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Tb_barangDataGridView.DataSource = Me.Tb_barangBindingSource
        Me.Tb_barangDataGridView.Location = New System.Drawing.Point(35, 333)
        Me.Tb_barangDataGridView.Name = "Tb_barangDataGridView"
        Me.Tb_barangDataGridView.ReadOnly = True
        Me.Tb_barangDataGridView.Size = New System.Drawing.Size(922, 220)
        Me.Tb_barangDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kode_barang"
        Me.DataGridViewTextBoxColumn1.HeaderText = "kode_barang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "kode_jenis"
        Me.DataGridViewTextBoxColumn2.HeaderText = "kode_jenis"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nama_barang"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nama_barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "kode_merk"
        Me.DataGridViewTextBoxColumn4.HeaderText = "kode_merk"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "harga_jual"
        Me.DataGridViewTextBoxColumn5.HeaderText = "harga_jual"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "harga_beli"
        Me.DataGridViewTextBoxColumn6.HeaderText = "harga_beli"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "stok_barang"
        Me.DataGridViewTextBoxColumn7.HeaderText = "stok_barang"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "keterangan"
        Me.DataGridViewTextBoxColumn8.HeaderText = "keterangan"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "kode_satuan"
        Me.DataGridViewTextBoxColumn9.HeaderText = "kode_satuan"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 137)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info Barang"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(222, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Harga_beliTextBox)
        Me.GroupBox2.Controls.Add(Harga_beliLabel)
        Me.GroupBox2.Controls.Add(Me.Harga_jualTextBox)
        Me.GroupBox2.Controls.Add(Harga_jualLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(379, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 165)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Harga"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonTambahBarang)
        Me.GroupBox3.Controls.Add(Me.ButtonSimpanBarang)
        Me.GroupBox3.Controls.Add(Me.KeywordTextBox)
        Me.GroupBox3.Controls.Add(Me.ButtonCariBarang)
        Me.GroupBox3.Controls.Add(Me.ButtonKeluarBarang)
        Me.GroupBox3.Controls.Add(Me.ButtonHapusBarang)
        Me.GroupBox3.Location = New System.Drawing.Point(755, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 277)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tombol"
        '
        'ButtonHapusBarang
        '
        Me.ButtonHapusBarang.ForeColor = System.Drawing.Color.Crimson
        Me.ButtonHapusBarang.Image = CType(resources.GetObject("ButtonHapusBarang.Image"), System.Drawing.Image)
        Me.ButtonHapusBarang.Location = New System.Drawing.Point(6, 105)
        Me.ButtonHapusBarang.Name = "ButtonHapusBarang"
        Me.ButtonHapusBarang.Size = New System.Drawing.Size(180, 35)
        Me.ButtonHapusBarang.TabIndex = 2
        Me.ButtonHapusBarang.Text = "Hapus"
        Me.ButtonHapusBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHapusBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonHapusBarang.UseVisualStyleBackColor = True
        '
        'ButtonKeluarBarang
        '
        Me.ButtonKeluarBarang.ForeColor = System.Drawing.Color.Crimson
        Me.ButtonKeluarBarang.Image = CType(resources.GetObject("ButtonKeluarBarang.Image"), System.Drawing.Image)
        Me.ButtonKeluarBarang.Location = New System.Drawing.Point(6, 149)
        Me.ButtonKeluarBarang.Name = "ButtonKeluarBarang"
        Me.ButtonKeluarBarang.Size = New System.Drawing.Size(180, 35)
        Me.ButtonKeluarBarang.TabIndex = 3
        Me.ButtonKeluarBarang.Text = "Keluar"
        Me.ButtonKeluarBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonKeluarBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonKeluarBarang.UseVisualStyleBackColor = True
        '
        'ButtonCariBarang
        '
        Me.ButtonCariBarang.ForeColor = System.Drawing.Color.Crimson
        Me.ButtonCariBarang.Image = CType(resources.GetObject("ButtonCariBarang.Image"), System.Drawing.Image)
        Me.ButtonCariBarang.Location = New System.Drawing.Point(6, 193)
        Me.ButtonCariBarang.Name = "ButtonCariBarang"
        Me.ButtonCariBarang.Size = New System.Drawing.Size(180, 35)
        Me.ButtonCariBarang.TabIndex = 4
        Me.ButtonCariBarang.Text = "Cari   "
        Me.ButtonCariBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCariBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCariBarang.UseVisualStyleBackColor = True
        '
        'KeywordTextBox
        '
        Me.KeywordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeywordTextBox.Location = New System.Drawing.Point(6, 236)
        Me.KeywordTextBox.Name = "KeywordTextBox"
        Me.KeywordTextBox.Size = New System.Drawing.Size(180, 29)
        Me.KeywordTextBox.TabIndex = 5
        '
        'ButtonSimpanBarang
        '
        Me.ButtonSimpanBarang.ForeColor = System.Drawing.Color.Crimson
        Me.ButtonSimpanBarang.Image = CType(resources.GetObject("ButtonSimpanBarang.Image"), System.Drawing.Image)
        Me.ButtonSimpanBarang.Location = New System.Drawing.Point(6, 62)
        Me.ButtonSimpanBarang.Name = "ButtonSimpanBarang"
        Me.ButtonSimpanBarang.Size = New System.Drawing.Size(180, 35)
        Me.ButtonSimpanBarang.TabIndex = 6
        Me.ButtonSimpanBarang.Text = "Simpan"
        Me.ButtonSimpanBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSimpanBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSimpanBarang.UseVisualStyleBackColor = True
        '
        'ButtonTambahBarang
        '
        Me.ButtonTambahBarang.ForeColor = System.Drawing.Color.Crimson
        Me.ButtonTambahBarang.Image = CType(resources.GetObject("ButtonTambahBarang.Image"), System.Drawing.Image)
        Me.ButtonTambahBarang.Location = New System.Drawing.Point(7, 19)
        Me.ButtonTambahBarang.Name = "ButtonTambahBarang"
        Me.ButtonTambahBarang.Size = New System.Drawing.Size(180, 35)
        Me.ButtonTambahBarang.TabIndex = 7
        Me.ButtonTambahBarang.Text = "Tambah"
        Me.ButtonTambahBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambahBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTambahBarang.UseVisualStyleBackColor = True
        '
        'FormPersonalManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 605)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Tb_barangDataGridView)
        Me.Controls.Add(Kode_barangLabel)
        Me.Controls.Add(Me.Kode_barangTextBox)
        Me.Controls.Add(Kode_jenisLabel)
        Me.Controls.Add(Me.Kode_jenisTextBox)
        Me.Controls.Add(Nama_barangLabel)
        Me.Controls.Add(Me.Nama_barangTextBox)
        Me.Controls.Add(Kode_merkLabel)
        Me.Controls.Add(Me.Kode_merkTextBox)
        Me.Controls.Add(Stok_barangLabel)
        Me.Controls.Add(Me.Stok_barangTextBox)
        Me.Controls.Add(KeteranganLabel)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Kode_satuanLabel)
        Me.Controls.Add(Me.Kode_satuanTextBox)
        Me.Controls.Add(Me.Tb_barangBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormPersonalManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPersonalManagement"
        CType(Me.DbPenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_barangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_barangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_barangBindingNavigator.ResumeLayout(False)
        Me.Tb_barangBindingNavigator.PerformLayout()
        CType(Me.Tb_barangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbPenjualanDataSet As DbPenjualanDataSet
	Friend WithEvents Tb_barangBindingSource As BindingSource
	Friend WithEvents Tb_barangTableAdapter As DbPenjualanDataSetTableAdapters.tb_barangTableAdapter
	Friend WithEvents TableAdapterManager As DbPenjualanDataSetTableAdapters.TableAdapterManager
	Friend WithEvents Tb_barangBindingNavigator As BindingNavigator
	Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents Tb_barangBindingNavigatorSaveItem As ToolStripButton
	Friend WithEvents Kode_barangTextBox As TextBox
	Friend WithEvents Kode_jenisTextBox As TextBox
	Friend WithEvents Nama_barangTextBox As TextBox
	Friend WithEvents Kode_merkTextBox As TextBox
	Friend WithEvents Harga_jualTextBox As TextBox
	Friend WithEvents Harga_beliTextBox As TextBox
	Friend WithEvents Stok_barangTextBox As TextBox
	Friend WithEvents KeteranganTextBox As TextBox
	Friend WithEvents Kode_satuanTextBox As TextBox
	Friend WithEvents Tb_barangDataGridView As DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents KeywordTextBox As TextBox
    Friend WithEvents ButtonCariBarang As Button
    Friend WithEvents ButtonKeluarBarang As Button
    Friend WithEvents ButtonHapusBarang As Button
    Friend WithEvents ButtonTambahBarang As Button
    Friend WithEvents ButtonSimpanBarang As Button
End Class
