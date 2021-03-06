﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAnnulusEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.VolumeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthofVolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VolumeofVolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Azimuthalangle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerticalAngle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElevationChange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HydraulicDiameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WallRoughness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThermalStratificationModel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LevelTrackingModel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WaterPackingScheme = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VerticalStratificationModel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InterphaseFriction = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComputeWallFriction = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EquilibriumTemperature = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCopytoAll = New System.Windows.Forms.Button()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.cmdPaste = New System.Windows.Forms.Button()
        Me.cmdPaste2 = New System.Windows.Forms.Button()
        Me.cmdCopy2 = New System.Windows.Forms.Button()
        Me.JunctionNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JunctionFlowArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FflowLossCo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RflowLossCo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVterm = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CCFLModel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StratificationEntrainmentModel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChokingModel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SmoothAreaChange = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TwoVelocityMomentumEquations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MomentumFlux = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.InterphaseVelocity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnterVelocityOrMassFlowRate = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InitialLiquidVelocity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialVaporVelocity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialLiquidMassFlowRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialVaporMassFlowRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JunctionHidraulicDiameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VolumeNumber, Me.FlowArea, Me.LengthofVolume, Me.VolumeofVolume, Me.Azimuthalangle, Me.VerticalAngle, Me.ElevationChange, Me.HydraulicDiameter, Me.WallRoughness, Me.ThermalStratificationModel, Me.LevelTrackingModel, Me.WaterPackingScheme, Me.VerticalStratificationModel, Me.InterphaseFriction, Me.ComputeWallFriction, Me.EquilibriumTemperature})
        Me.dgv.Location = New System.Drawing.Point(8, 8)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1052, 282)
        Me.dgv.TabIndex = 5
        '
        'VolumeNumber
        '
        Me.VolumeNumber.HeaderText = "Volume Number"
        Me.VolumeNumber.Name = "VolumeNumber"
        Me.VolumeNumber.ReadOnly = True
        '
        'FlowArea
        '
        Me.FlowArea.HeaderText = "Volume Flow Area"
        Me.FlowArea.Name = "FlowArea"
        '
        'LengthofVolume
        '
        Me.LengthofVolume.HeaderText = "Length of Volume"
        Me.LengthofVolume.Name = "LengthofVolume"
        '
        'VolumeofVolume
        '
        Me.VolumeofVolume.HeaderText = "Volume of Volume"
        Me.VolumeofVolume.Name = "VolumeofVolume"
        '
        'Azimuthalangle
        '
        Me.Azimuthalangle.HeaderText = "Azimuthal angle"
        Me.Azimuthalangle.Name = "Azimuthalangle"
        '
        'VerticalAngle
        '
        Me.VerticalAngle.HeaderText = "Vertical Angle"
        Me.VerticalAngle.Name = "VerticalAngle"
        '
        'ElevationChange
        '
        Me.ElevationChange.HeaderText = "Elevation Change"
        Me.ElevationChange.Name = "ElevationChange"
        '
        'HydraulicDiameter
        '
        Me.HydraulicDiameter.HeaderText = "Hydraulic Diameter"
        Me.HydraulicDiameter.Name = "HydraulicDiameter"
        '
        'WallRoughness
        '
        Me.WallRoughness.HeaderText = "Wall Roughness"
        Me.WallRoughness.Name = "WallRoughness"
        '
        'ThermalStratificationModel
        '
        Me.ThermalStratificationModel.HeaderText = "Thermal Stratification Model "
        Me.ThermalStratificationModel.Name = "ThermalStratificationModel"
        Me.ThermalStratificationModel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ThermalStratificationModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'LevelTrackingModel
        '
        Me.LevelTrackingModel.HeaderText = "Level Tracking Model"
        Me.LevelTrackingModel.Name = "LevelTrackingModel"
        Me.LevelTrackingModel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LevelTrackingModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'WaterPackingScheme
        '
        Me.WaterPackingScheme.HeaderText = "Water Packing Scheme "
        Me.WaterPackingScheme.Name = "WaterPackingScheme"
        Me.WaterPackingScheme.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WaterPackingScheme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'VerticalStratificationModel
        '
        Me.VerticalStratificationModel.HeaderText = "Vertical Stratification Model "
        Me.VerticalStratificationModel.Name = "VerticalStratificationModel"
        Me.VerticalStratificationModel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VerticalStratificationModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'InterphaseFriction
        '
        Me.InterphaseFriction.HeaderText = "Interphase Friction"
        Me.InterphaseFriction.Name = "InterphaseFriction"
        Me.InterphaseFriction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InterphaseFriction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ComputeWallFriction
        '
        Me.ComputeWallFriction.HeaderText = "Compute WallFriction"
        Me.ComputeWallFriction.Name = "ComputeWallFriction"
        Me.ComputeWallFriction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ComputeWallFriction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'EquilibriumTemperature
        '
        Me.EquilibriumTemperature.HeaderText = "Equilibrium Temperature"
        Me.EquilibriumTemperature.Name = "EquilibriumTemperature"
        Me.EquilibriumTemperature.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EquilibriumTemperature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JunctionNumber, Me.JunctionFlowArea, Me.FflowLossCo, Me.RflowLossCo, Me.PVterm, Me.CCFLModel, Me.StratificationEntrainmentModel, Me.ChokingModel, Me.SmoothAreaChange, Me.TwoVelocityMomentumEquations, Me.MomentumFlux, Me.InterphaseVelocity, Me.EnterVelocityOrMassFlowRate, Me.InitialLiquidVelocity, Me.InitialVaporVelocity, Me.InitialLiquidMassFlowRate, Me.InitialVaporMassFlowRate, Me.JunctionHidraulicDiameter})
        Me.dgv2.Location = New System.Drawing.Point(8, 346)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(1052, 280)
        Me.dgv2.TabIndex = 6
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(381, 308)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 14
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCopytoAll
        '
        Me.cmdCopytoAll.Enabled = False
        Me.cmdCopytoAll.Location = New System.Drawing.Point(288, 308)
        Me.cmdCopytoAll.Name = "cmdCopytoAll"
        Me.cmdCopytoAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopytoAll.TabIndex = 13
        Me.cmdCopytoAll.Text = "Copy to All"
        Me.cmdCopytoAll.UseVisualStyleBackColor = True
        '
        'cmdCopy
        '
        Me.cmdCopy.Enabled = False
        Me.cmdCopy.Location = New System.Drawing.Point(112, 308)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopy.TabIndex = 11
        Me.cmdCopy.Text = "Copy"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'cmdPaste
        '
        Me.cmdPaste.Enabled = False
        Me.cmdPaste.Location = New System.Drawing.Point(193, 308)
        Me.cmdPaste.Name = "cmdPaste"
        Me.cmdPaste.Size = New System.Drawing.Size(75, 23)
        Me.cmdPaste.TabIndex = 12
        Me.cmdPaste.Text = "Paste"
        Me.cmdPaste.UseVisualStyleBackColor = True
        '
        'cmdPaste2
        '
        Me.cmdPaste2.Enabled = False
        Me.cmdPaste2.Location = New System.Drawing.Point(214, 645)
        Me.cmdPaste2.Name = "cmdPaste2"
        Me.cmdPaste2.Size = New System.Drawing.Size(75, 23)
        Me.cmdPaste2.TabIndex = 16
        Me.cmdPaste2.Text = "Paste"
        Me.cmdPaste2.UseVisualStyleBackColor = True
        '
        'cmdCopy2
        '
        Me.cmdCopy2.Enabled = False
        Me.cmdCopy2.Location = New System.Drawing.Point(112, 645)
        Me.cmdCopy2.Name = "cmdCopy2"
        Me.cmdCopy2.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopy2.TabIndex = 15
        Me.cmdCopy2.Text = "Copy"
        Me.cmdCopy2.UseVisualStyleBackColor = True
        '
        'JunctionNumber
        '
        Me.JunctionNumber.HeaderText = "Junction Number"
        Me.JunctionNumber.Name = "JunctionNumber"
        Me.JunctionNumber.ReadOnly = True
        '
        'JunctionFlowArea
        '
        Me.JunctionFlowArea.HeaderText = "Junction Flow Area"
        Me.JunctionFlowArea.Name = "JunctionFlowArea"
        '
        'FflowLossCo
        '
        Me.FflowLossCo.HeaderText = "Forward Flow Energy Loss Coefficient"
        Me.FflowLossCo.Name = "FflowLossCo"
        '
        'RflowLossCo
        '
        Me.RflowLossCo.HeaderText = "Forward Flow Energy Loss Coefficient"
        Me.RflowLossCo.Name = "RflowLossCo"
        '
        'PVterm
        '
        Me.PVterm.HeaderText = "PV Term"
        Me.PVterm.Name = "PVterm"
        Me.PVterm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PVterm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CCFLModel
        '
        Me.CCFLModel.HeaderText = "CCFL Model"
        Me.CCFLModel.Name = "CCFLModel"
        Me.CCFLModel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CCFLModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'StratificationEntrainmentModel
        '
        Me.StratificationEntrainmentModel.HeaderText = "Horizontal Stratification Entrainment Model "
        Me.StratificationEntrainmentModel.Name = "StratificationEntrainmentModel"
        Me.StratificationEntrainmentModel.ReadOnly = True
        Me.StratificationEntrainmentModel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StratificationEntrainmentModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.StratificationEntrainmentModel.Visible = False
        '
        'ChokingModel
        '
        Me.ChokingModel.HeaderText = "Choking Model "
        Me.ChokingModel.Name = "ChokingModel"
        Me.ChokingModel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChokingModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SmoothAreaChange
        '
        Me.SmoothAreaChange.HeaderText = "Area Change "
        Me.SmoothAreaChange.Items.AddRange(New Object() {"Smooth Area Change", "Full Abrupt Area Change", "Partial Abrupt Area Change"})
        Me.SmoothAreaChange.Name = "SmoothAreaChange"
        Me.SmoothAreaChange.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SmoothAreaChange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TwoVelocityMomentumEquations
        '
        Me.TwoVelocityMomentumEquations.HeaderText = "Velocity Momentum Equations "
        Me.TwoVelocityMomentumEquations.Items.AddRange(New Object() {"Two velocity Momentum Equations", "Single velocity Momentum Equations"})
        Me.TwoVelocityMomentumEquations.Name = "TwoVelocityMomentumEquations"
        Me.TwoVelocityMomentumEquations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TwoVelocityMomentumEquations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MomentumFlux
        '
        Me.MomentumFlux.HeaderText = "Momentum Flux"
        Me.MomentumFlux.Items.AddRange(New Object() {"To and From Volume", "Only From Volume", "Only To Volume", "Do not use Momentum Flux"})
        Me.MomentumFlux.Name = "MomentumFlux"
        Me.MomentumFlux.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MomentumFlux.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'InterphaseVelocity
        '
        Me.InterphaseVelocity.HeaderText = "Interphase Velocity"
        Me.InterphaseVelocity.Name = "InterphaseVelocity"
        '
        'EnterVelocityOrMassFlowRate
        '
        Me.EnterVelocityOrMassFlowRate.HeaderText = "Check for mass flow rates"
        Me.EnterVelocityOrMassFlowRate.Name = "EnterVelocityOrMassFlowRate"
        '
        'InitialLiquidVelocity
        '
        Me.InitialLiquidVelocity.HeaderText = "Initial Liquid Velocity"
        Me.InitialLiquidVelocity.Name = "InitialLiquidVelocity"
        '
        'InitialVaporVelocity
        '
        Me.InitialVaporVelocity.HeaderText = "Initial Vapor Velocity"
        Me.InitialVaporVelocity.Name = "InitialVaporVelocity"
        '
        'InitialLiquidMassFlowRate
        '
        Me.InitialLiquidMassFlowRate.HeaderText = "Initial Liquid Mass Flow Rate"
        Me.InitialLiquidMassFlowRate.Name = "InitialLiquidMassFlowRate"
        '
        'InitialVaporMassFlowRate
        '
        Me.InitialVaporMassFlowRate.HeaderText = "Initial Vapor Mass Flow Rate"
        Me.InitialVaporMassFlowRate.Name = "InitialVaporMassFlowRate"
        '
        'JunctionHidraulicDiameter
        '
        Me.JunctionHidraulicDiameter.HeaderText = "Junction Hidarulic Diameter"
        Me.JunctionHidraulicDiameter.Name = "JunctionHidraulicDiameter"
        '
        'ucAnnulusEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdPaste2)
        Me.Controls.Add(Me.cmdCopy2)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCopytoAll)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.cmdPaste)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.dgv)
        Me.Name = "ucAnnulusEditor"
        Me.Size = New System.Drawing.Size(1076, 684)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents VolumeNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LengthofVolume As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumeofVolume As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Azimuthalangle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerticalAngle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ElevationChange As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HydraulicDiameter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WallRoughness As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThermalStratificationModel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LevelTrackingModel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WaterPackingScheme As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VerticalStratificationModel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InterphaseFriction As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ComputeWallFriction As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EquilibriumTemperature As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCopytoAll As System.Windows.Forms.Button
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents cmdPaste As System.Windows.Forms.Button
    Friend WithEvents cmdPaste2 As System.Windows.Forms.Button
    Friend WithEvents cmdCopy2 As System.Windows.Forms.Button
    Friend WithEvents JunctionNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JunctionFlowArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FflowLossCo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RflowLossCo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVterm As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CCFLModel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StratificationEntrainmentModel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ChokingModel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SmoothAreaChange As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TwoVelocityMomentumEquations As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents MomentumFlux As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents InterphaseVelocity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnterVelocityOrMassFlowRate As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InitialLiquidVelocity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InitialVaporVelocity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InitialLiquidMassFlowRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InitialVaporMassFlowRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JunctionHidraulicDiameter As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
