﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEBT
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.cmbothermostates = New System.Windows.Forms.ComboBox()
        Me.lblthermostates = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'cmbothermostates
        '
        Me.cmbothermostates.FormattingEnabled = True
        Me.cmbothermostates.Items.AddRange(New Object() {"Pressure, Liquid Specific Internal Energy, Vapor Specific Internal Energy, Void F" & _
                        "raction", "Temperature, Static Quality", "Pressure, Static Quality", "Pressure, Temperature", "Pressure, Temperature, Static Quality", "Temperature, Static Quality, Non condensable Quality", "Pressure, Liquid Specific Internal Energy, Vapor Specific Internal Energy, Void F" & _
                        "raction, Non condensable Quality", "Pressure, Liquid Temperature, Vapor Temperature, Void Fraction, Non condensable Q" & _
                        "uality"})
        Me.cmbothermostates.Location = New System.Drawing.Point(49, 175)
        Me.cmbothermostates.Name = "cmbothermostates"
        Me.cmbothermostates.Size = New System.Drawing.Size(606, 21)
        Me.cmbothermostates.TabIndex = 0
        '
        'lblthermostates
        '
        Me.lblthermostates.AutoSize = True
        Me.lblthermostates.Location = New System.Drawing.Point(46, 147)
        Me.lblthermostates.Name = "lblthermostates"
        Me.lblthermostates.Size = New System.Drawing.Size(215, 13)
        Me.lblthermostates.TabIndex = 1
        Me.lblthermostates.Text = "Please Select Initial Thermodynamics States"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(582, 129)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'frmEBT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 262)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblthermostates)
        Me.Controls.Add(Me.cmbothermostates)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmEBT"
        Me.Text = "FormEBT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbothermostates As System.Windows.Forms.ComboBox
    Friend WithEvents lblthermostates As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class