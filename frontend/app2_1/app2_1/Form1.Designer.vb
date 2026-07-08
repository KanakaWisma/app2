<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlFrame = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.txtFakultas = New System.Windows.Forms.TextBox()
        Me.lblJenjang = New System.Windows.Forms.Label()
        Me.cmbJenjang = New System.Windows.Forms.ComboBox()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblList = New System.Windows.Forms.Label()
        Me.dgvMahasiswa = New System.Windows.Forms.ListBox()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlFrame.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFrame
        '
        Me.pnlFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFrame.Controls.Add(Me.lblHeader)
        Me.pnlFrame.Controls.Add(Me.pnlContent)
        Me.pnlFrame.Controls.Add(Me.pnlFooter)
        Me.pnlFrame.Location = New System.Drawing.Point(8, 8)
        Me.pnlFrame.Name = "pnlFrame"
        Me.pnlFrame.Size = New System.Drawing.Size(764, 524)
        Me.pnlFrame.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(762, 56)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Informasi Mahasiswa"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.pnlLeft)
        Me.pnlContent.Controls.Add(Me.pnlRight)
        Me.pnlContent.Location = New System.Drawing.Point(8, 64)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(746, 392)
        Me.pnlContent.TabIndex = 1
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.cmbJurusan)
        Me.pnlLeft.Controls.Add(Me.DateTimePicker1)
        Me.pnlLeft.Controls.Add(Me.lblNama)
        Me.pnlLeft.Controls.Add(Me.txtNama)
        Me.pnlLeft.Controls.Add(Me.lblUmur)
        Me.pnlLeft.Controls.Add(Me.txtUmur)
        Me.pnlLeft.Controls.Add(Me.lblNIM)
        Me.pnlLeft.Controls.Add(Me.txtNIM)
        Me.pnlLeft.Controls.Add(Me.lblTgl)
        Me.pnlLeft.Controls.Add(Me.lblAlamat)
        Me.pnlLeft.Controls.Add(Me.txtAlamat)
        Me.pnlLeft.Controls.Add(Me.lblJurusan)
        Me.pnlLeft.Controls.Add(Me.lblFakultas)
        Me.pnlLeft.Controls.Add(Me.txtFakultas)
        Me.pnlLeft.Controls.Add(Me.lblJenjang)
        Me.pnlLeft.Controls.Add(Me.cmbJenjang)
        Me.pnlLeft.Location = New System.Drawing.Point(8, 8)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(420, 376)
        Me.pnlLeft.TabIndex = 0
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(120, 214)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(233, 24)
        Me.cmbJurusan.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 103)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 16
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(12, 12)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(50, 16)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(120, 8)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(280, 22)
        Me.txtNama.TabIndex = 1
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.Location = New System.Drawing.Point(12, 44)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(45, 16)
        Me.lblUmur.TabIndex = 2
        Me.lblUmur.Text = "Umur :"
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(120, 40)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(120, 22)
        Me.txtUmur.TabIndex = 3
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Location = New System.Drawing.Point(12, 76)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(37, 16)
        Me.lblNIM.TabIndex = 4
        Me.lblNIM.Text = "NIM :"
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(120, 72)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(180, 22)
        Me.txtNIM.TabIndex = 5
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(12, 108)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(65, 16)
        Me.lblTgl.TabIndex = 6
        Me.lblTgl.Text = "Tgl Lahir :"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(12, 140)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(55, 16)
        Me.lblAlamat.TabIndex = 8
        Me.lblAlamat.Text = "Alamat :"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(120, 136)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(280, 72)
        Me.txtAlamat.TabIndex = 9
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(12, 220)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(60, 16)
        Me.lblJurusan.TabIndex = 10
        Me.lblJurusan.Text = "Jurusan :"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(12, 252)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(64, 16)
        Me.lblFakultas.TabIndex = 12
        Me.lblFakultas.Text = "Fakultas :"
        '
        'txtFakultas
        '
        Me.txtFakultas.Location = New System.Drawing.Point(120, 248)
        Me.txtFakultas.Name = "txtFakultas"
        Me.txtFakultas.Size = New System.Drawing.Size(200, 22)
        Me.txtFakultas.TabIndex = 13
        '
        'lblJenjang
        '
        Me.lblJenjang.AutoSize = True
        Me.lblJenjang.Location = New System.Drawing.Point(12, 284)
        Me.lblJenjang.Name = "lblJenjang"
        Me.lblJenjang.Size = New System.Drawing.Size(61, 16)
        Me.lblJenjang.TabIndex = 14
        Me.lblJenjang.Text = "Jenjang :"
        '
        'cmbJenjang
        '
        Me.cmbJenjang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenjang.Items.AddRange(New Object() {"S1", "S2", "D3"})
        Me.cmbJenjang.Location = New System.Drawing.Point(120, 280)
        Me.cmbJenjang.Name = "cmbJenjang"
        Me.cmbJenjang.Size = New System.Drawing.Size(120, 24)
        Me.cmbJenjang.TabIndex = 15
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.txtSearch)
        Me.pnlRight.Controls.Add(Me.btnSearch)
        Me.pnlRight.Controls.Add(Me.lblList)
        Me.pnlRight.Controls.Add(Me.dgvMahasiswa)
        Me.pnlRight.Location = New System.Drawing.Point(440, 8)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(294, 376)
        Me.pnlRight.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(8, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(210, 22)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(224, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 26)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "🔍"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Location = New System.Drawing.Point(8, 44)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(130, 16)
        Me.lblList.TabIndex = 2
        Me.lblList.Text = "List Data Mahasiswa"
        '
        'dgvMahasiswa
        '
        Me.dgvMahasiswa.ItemHeight = 16
        Me.dgvMahasiswa.Location = New System.Drawing.Point(8, 68)
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.Size = New System.Drawing.Size(268, 292)
        Me.dgvMahasiswa.TabIndex = 3
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.btnReset)
        Me.pnlFooter.Controls.Add(Me.btnUpdate)
        Me.pnlFooter.Controls.Add(Me.btnSave)
        Me.pnlFooter.Controls.Add(Me.btnDelete)
        Me.pnlFooter.Location = New System.Drawing.Point(8, 464)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(746, 48)
        Me.pnlFooter.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(170, 8)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 30)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(266, 8)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 30)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(362, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(458, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 540)
        Me.Controls.Add(Me.pnlFrame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlFrame.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFrame As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblUmur As System.Windows.Forms.Label
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents lblNIM As System.Windows.Forms.Label
    Friend WithEvents txtNIM As System.Windows.Forms.TextBox
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents lblFakultas As System.Windows.Forms.Label
    Friend WithEvents txtFakultas As System.Windows.Forms.TextBox
    Friend WithEvents lblJenjang As System.Windows.Forms.Label
    Friend WithEvents cmbJenjang As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.ListBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbJurusan As ComboBox
End Class
