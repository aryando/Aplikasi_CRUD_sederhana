<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDosen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAryando3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAryando4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAryando5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAryando6 = New System.Windows.Forms.TextBox()
        Me.dgvDosen = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIDN"
        '
        'txtAryando3
        '
        Me.txtAryando3.Location = New System.Drawing.Point(262, 66)
        Me.txtAryando3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAryando3.Name = "txtAryando3"
        Me.txtAryando3.Size = New System.Drawing.Size(298, 26)
        Me.txtAryando3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Dosen"
        '
        'txtAryando4
        '
        Me.txtAryando4.Location = New System.Drawing.Point(262, 108)
        Me.txtAryando4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAryando4.Name = "txtAryando4"
        Me.txtAryando4.Size = New System.Drawing.Size(298, 26)
        Me.txtAryando4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tgl Lahir"
        '
        'dtpLahir
        '
        Me.dtpLahir.Location = New System.Drawing.Point(262, 152)
        Me.dtpLahir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpLahir.Name = "dtpLahir"
        Me.dtpLahir.Size = New System.Drawing.Size(298, 26)
        Me.dtpLahir.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jenis Kelamin"
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbGender.Location = New System.Drawing.Point(262, 188)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(298, 28)
        Me.cbGender.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gaji Pokok"
        '
        'txtAryando5
        '
        Me.txtAryando5.Location = New System.Drawing.Point(262, 226)
        Me.txtAryando5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAryando5.Name = "txtAryando5"
        Me.txtAryando5.Size = New System.Drawing.Size(298, 26)
        Me.txtAryando5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 268)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Alamat"
        '
        'txtAryando6
        '
        Me.txtAryando6.Location = New System.Drawing.Point(262, 262)
        Me.txtAryando6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAryando6.Name = "txtAryando6"
        Me.txtAryando6.Size = New System.Drawing.Size(298, 26)
        Me.txtAryando6.TabIndex = 11
        '
        'dgvDosen
        '
        Me.dgvDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDosen.Location = New System.Drawing.Point(121, 389)
        Me.dgvDosen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvDosen.Name = "dgvDosen"
        Me.dgvDosen.RowHeadersWidth = 62
        Me.dgvDosen.Size = New System.Drawing.Size(975, 192)
        Me.dgvDosen.TabIndex = 12
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(121, 315)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(112, 35)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(271, 315)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(112, 35)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(579, 315)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 35)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(423, 315)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(112, 35)
        Me.btnBatal.TabIndex = 16
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'FormDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dgvDosen)
        Me.Controls.Add(Me.txtAryando6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAryando5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpLahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAryando4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAryando3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormDosen"
        Me.Text = "FormDosen"
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAryando3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAryando4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAryando5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAryando6 As TextBox
    Friend WithEvents dgvDosen As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
End Class
