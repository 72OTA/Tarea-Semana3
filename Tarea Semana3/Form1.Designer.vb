<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMDI
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
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

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMDI))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.IngresarDietaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InformeDeDietaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EnsambladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tcIngresar = New System.Windows.Forms.TabControl()
		Me.tcIngresarDieta = New System.Windows.Forms.TabPage()
		Me.tcComidas = New System.Windows.Forms.TabControl()
		Me.tpDesayuno = New System.Windows.Forms.TabPage()
		Me.lbComestible = New System.Windows.Forms.Label()
		Me.lbBebestible = New System.Windows.Forms.Label()
		Me.lbDesayunoC = New System.Windows.Forms.ListBox()
		Me.lbDesayunoB = New System.Windows.Forms.ListBox()
		Me.tpAlmuerzo = New System.Windows.Forms.TabPage()
		Me.lbAcompañamiento = New System.Windows.Forms.Label()
		Me.lbProteina = New System.Windows.Forms.Label()
		Me.lbAlmuerzoC = New System.Windows.Forms.ListBox()
		Me.lbAlmuerzoB = New System.Windows.Forms.ListBox()
		Me.tpCena = New System.Windows.Forms.TabPage()
		Me.lbFruta = New System.Windows.Forms.Label()
		Me.lbVerdura = New System.Windows.Forms.Label()
		Me.lbCenaC = New System.Windows.Forms.ListBox()
		Me.lbCenaB = New System.Windows.Forms.ListBox()
		Me.btnDomingo = New System.Windows.Forms.Button()
		Me.btnJueves = New System.Windows.Forms.Button()
		Me.btnSabado = New System.Windows.Forms.Button()
		Me.btnViernes = New System.Windows.Forms.Button()
		Me.cbDias = New System.Windows.Forms.ComboBox()
		Me.tcInformeDieta = New System.Windows.Forms.TabPage()
		Me.tcEnsamblado = New System.Windows.Forms.TabPage()
		Me.btnEnsamblado = New System.Windows.Forms.Button()
		Me.btnInforme = New System.Windows.Forms.Button()
		Me.MenuStrip1.SuspendLayout()
		Me.tcIngresar.SuspendLayout()
		Me.tcIngresarDieta.SuspendLayout()
		Me.tcComidas.SuspendLayout()
		Me.tpDesayuno.SuspendLayout()
		Me.tpAlmuerzo.SuspendLayout()
		Me.tpCena.SuspendLayout()
		Me.tcInformeDieta.SuspendLayout()
		Me.tcEnsamblado.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'NuevoToolStripMenuItem
		'
		Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDietaToolStripMenuItem, Me.InformeDeDietaToolStripMenuItem, Me.EnsambladoToolStripMenuItem})
		Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
		Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
		Me.NuevoToolStripMenuItem.Text = "&Nuevo"
		'
		'IngresarDietaToolStripMenuItem
		'
		Me.IngresarDietaToolStripMenuItem.Name = "IngresarDietaToolStripMenuItem"
		Me.IngresarDietaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.IngresarDietaToolStripMenuItem.Text = "&Ingresar Dieta"
		'
		'InformeDeDietaToolStripMenuItem
		'
		Me.InformeDeDietaToolStripMenuItem.Name = "InformeDeDietaToolStripMenuItem"
		Me.InformeDeDietaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.InformeDeDietaToolStripMenuItem.Text = "Informe de &Dieta"
		'
		'EnsambladoToolStripMenuItem
		'
		Me.EnsambladoToolStripMenuItem.Name = "EnsambladoToolStripMenuItem"
		Me.EnsambladoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.EnsambladoToolStripMenuItem.Text = "&Ensamblado"
		'
		'tcIngresar
		'
		Me.tcIngresar.Controls.Add(Me.tcIngresarDieta)
		Me.tcIngresar.Controls.Add(Me.tcInformeDieta)
		Me.tcIngresar.Controls.Add(Me.tcEnsamblado)
		Me.tcIngresar.Location = New System.Drawing.Point(0, 27)
		Me.tcIngresar.Name = "tcIngresar"
		Me.tcIngresar.SelectedIndex = 0
		Me.tcIngresar.Size = New System.Drawing.Size(800, 327)
		Me.tcIngresar.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
		Me.tcIngresar.TabIndex = 3
		'
		'tcIngresarDieta
		'
		Me.tcIngresarDieta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tcIngresarDieta.Controls.Add(Me.tcComidas)
		Me.tcIngresarDieta.Controls.Add(Me.btnDomingo)
		Me.tcIngresarDieta.Controls.Add(Me.btnJueves)
		Me.tcIngresarDieta.Controls.Add(Me.btnSabado)
		Me.tcIngresarDieta.Controls.Add(Me.btnViernes)
		Me.tcIngresarDieta.Controls.Add(Me.cbDias)
		Me.tcIngresarDieta.Location = New System.Drawing.Point(4, 22)
		Me.tcIngresarDieta.Name = "tcIngresarDieta"
		Me.tcIngresarDieta.Padding = New System.Windows.Forms.Padding(3)
		Me.tcIngresarDieta.Size = New System.Drawing.Size(792, 301)
		Me.tcIngresarDieta.TabIndex = 0
		Me.tcIngresarDieta.Text = "Ingresar Dieta"
		Me.tcIngresarDieta.UseVisualStyleBackColor = True
		'
		'tcComidas
		'
		Me.tcComidas.Controls.Add(Me.tpDesayuno)
		Me.tcComidas.Controls.Add(Me.tpAlmuerzo)
		Me.tcComidas.Controls.Add(Me.tpCena)
		Me.tcComidas.Location = New System.Drawing.Point(370, 18)
		Me.tcComidas.Name = "tcComidas"
		Me.tcComidas.SelectedIndex = 0
		Me.tcComidas.Size = New System.Drawing.Size(266, 275)
		Me.tcComidas.TabIndex = 5
		'
		'tpDesayuno
		'
		Me.tpDesayuno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tpDesayuno.Controls.Add(Me.lbComestible)
		Me.tpDesayuno.Controls.Add(Me.lbBebestible)
		Me.tpDesayuno.Controls.Add(Me.lbDesayunoC)
		Me.tpDesayuno.Controls.Add(Me.lbDesayunoB)
		Me.tpDesayuno.Location = New System.Drawing.Point(4, 22)
		Me.tpDesayuno.Name = "tpDesayuno"
		Me.tpDesayuno.Padding = New System.Windows.Forms.Padding(3)
		Me.tpDesayuno.Size = New System.Drawing.Size(258, 249)
		Me.tpDesayuno.TabIndex = 0
		Me.tpDesayuno.Text = "Desayuno"
		Me.tpDesayuno.UseVisualStyleBackColor = True
		'
		'lbComestible
		'
		Me.lbComestible.AutoSize = True
		Me.lbComestible.Location = New System.Drawing.Point(130, 8)
		Me.lbComestible.Name = "lbComestible"
		Me.lbComestible.Size = New System.Drawing.Size(58, 13)
		Me.lbComestible.TabIndex = 7
		Me.lbComestible.Text = "Comestible"
		'
		'lbBebestible
		'
		Me.lbBebestible.AutoSize = True
		Me.lbBebestible.Location = New System.Drawing.Point(6, 9)
		Me.lbBebestible.Name = "lbBebestible"
		Me.lbBebestible.Size = New System.Drawing.Size(56, 13)
		Me.lbBebestible.TabIndex = 6
		Me.lbBebestible.Text = "Bebestible"
		'
		'lbDesayunoC
		'
		Me.lbDesayunoC.FormattingEnabled = True
		Me.lbDesayunoC.Items.AddRange(New Object() {"Tostada integral", "Tostada con mantequilla", "Tostada con Jamón", "Tostada con Palta", "Marraqueta", "Marraqueta con Tomate", "Marraqueta con Salame"})
		Me.lbDesayunoC.Location = New System.Drawing.Point(130, 29)
		Me.lbDesayunoC.Name = "lbDesayunoC"
		Me.lbDesayunoC.Size = New System.Drawing.Size(120, 212)
		Me.lbDesayunoC.TabIndex = 1
		'
		'lbDesayunoB
		'
		Me.lbDesayunoB.FormattingEnabled = True
		Me.lbDesayunoB.Items.AddRange(New Object() {"Té solo", "Té con leche", "Café solo", "Café con leche", "Café express", "Café cortado", "Capuccino"})
		Me.lbDesayunoB.Location = New System.Drawing.Point(6, 29)
		Me.lbDesayunoB.Name = "lbDesayunoB"
		Me.lbDesayunoB.Size = New System.Drawing.Size(120, 212)
		Me.lbDesayunoB.TabIndex = 0
		'
		'tpAlmuerzo
		'
		Me.tpAlmuerzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tpAlmuerzo.Controls.Add(Me.lbAcompañamiento)
		Me.tpAlmuerzo.Controls.Add(Me.lbProteina)
		Me.tpAlmuerzo.Controls.Add(Me.lbAlmuerzoC)
		Me.tpAlmuerzo.Controls.Add(Me.lbAlmuerzoB)
		Me.tpAlmuerzo.Location = New System.Drawing.Point(4, 22)
		Me.tpAlmuerzo.Name = "tpAlmuerzo"
		Me.tpAlmuerzo.Padding = New System.Windows.Forms.Padding(3)
		Me.tpAlmuerzo.Size = New System.Drawing.Size(258, 249)
		Me.tpAlmuerzo.TabIndex = 1
		Me.tpAlmuerzo.Text = "Almuerzo"
		Me.tpAlmuerzo.UseVisualStyleBackColor = True
		'
		'lbAcompañamiento
		'
		Me.lbAcompañamiento.AutoSize = True
		Me.lbAcompañamiento.Location = New System.Drawing.Point(130, 13)
		Me.lbAcompañamiento.Name = "lbAcompañamiento"
		Me.lbAcompañamiento.Size = New System.Drawing.Size(89, 13)
		Me.lbAcompañamiento.TabIndex = 5
		Me.lbAcompañamiento.Text = "Acompañamiento"
		'
		'lbProteina
		'
		Me.lbProteina.AutoSize = True
		Me.lbProteina.Location = New System.Drawing.Point(7, 14)
		Me.lbProteina.Name = "lbProteina"
		Me.lbProteina.Size = New System.Drawing.Size(48, 13)
		Me.lbProteina.TabIndex = 4
		Me.lbProteina.Text = "Proteína"
		'
		'lbAlmuerzoC
		'
		Me.lbAlmuerzoC.FormattingEnabled = True
		Me.lbAlmuerzoC.Items.AddRange(New Object() {"Arroz Integral", "Fideos", "Puré", "Papas Cocidas", "Ensalada Surtida", "Legumbres", "Sopa"})
		Me.lbAlmuerzoC.Location = New System.Drawing.Point(130, 33)
		Me.lbAlmuerzoC.Name = "lbAlmuerzoC"
		Me.lbAlmuerzoC.Size = New System.Drawing.Size(120, 212)
		Me.lbAlmuerzoC.TabIndex = 3
		'
		'lbAlmuerzoB
		'
		Me.lbAlmuerzoB.FormattingEnabled = True
		Me.lbAlmuerzoB.Items.AddRange(New Object() {"Churrasco", "Bistec", "Chuleta", "Costillar", "Pavo", "Pollo", "Salmón", "Atún"})
		Me.lbAlmuerzoB.Location = New System.Drawing.Point(6, 33)
		Me.lbAlmuerzoB.Name = "lbAlmuerzoB"
		Me.lbAlmuerzoB.Size = New System.Drawing.Size(120, 212)
		Me.lbAlmuerzoB.TabIndex = 2
		'
		'tpCena
		'
		Me.tpCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tpCena.Controls.Add(Me.lbFruta)
		Me.tpCena.Controls.Add(Me.lbVerdura)
		Me.tpCena.Controls.Add(Me.lbCenaC)
		Me.tpCena.Controls.Add(Me.lbCenaB)
		Me.tpCena.Location = New System.Drawing.Point(4, 22)
		Me.tpCena.Name = "tpCena"
		Me.tpCena.Size = New System.Drawing.Size(258, 249)
		Me.tpCena.TabIndex = 2
		Me.tpCena.Text = "Cena"
		Me.tpCena.UseVisualStyleBackColor = True
		'
		'lbFruta
		'
		Me.lbFruta.AutoSize = True
		Me.lbFruta.Location = New System.Drawing.Point(133, 12)
		Me.lbFruta.Name = "lbFruta"
		Me.lbFruta.Size = New System.Drawing.Size(31, 13)
		Me.lbFruta.TabIndex = 5
		Me.lbFruta.Text = "Fruta"
		'
		'lbVerdura
		'
		Me.lbVerdura.AutoSize = True
		Me.lbVerdura.Location = New System.Drawing.Point(4, 13)
		Me.lbVerdura.Name = "lbVerdura"
		Me.lbVerdura.Size = New System.Drawing.Size(44, 13)
		Me.lbVerdura.TabIndex = 4
		Me.lbVerdura.Text = "Verdura"
		'
		'lbCenaC
		'
		Me.lbCenaC.FormattingEnabled = True
		Me.lbCenaC.Items.AddRange(New Object() {"Naranja", "Manzana", "Plátano", "Uva", "Kiwi", "Piña", "Frutilla", "Durazno"})
		Me.lbCenaC.Location = New System.Drawing.Point(133, 32)
		Me.lbCenaC.Name = "lbCenaC"
		Me.lbCenaC.Size = New System.Drawing.Size(120, 212)
		Me.lbCenaC.TabIndex = 3
		'
		'lbCenaB
		'
		Me.lbCenaB.FormattingEnabled = True
		Me.lbCenaB.Items.AddRange(New Object() {"Zanahoria", "Tomate", "Palta", "Lechuga", "Espinaca", "Apio"})
		Me.lbCenaB.Location = New System.Drawing.Point(3, 32)
		Me.lbCenaB.Name = "lbCenaB"
		Me.lbCenaB.Size = New System.Drawing.Size(120, 212)
		Me.lbCenaB.TabIndex = 2
		'
		'btnDomingo
		'
		Me.btnDomingo.Location = New System.Drawing.Point(16, 133)
		Me.btnDomingo.Name = "btnDomingo"
		Me.btnDomingo.Size = New System.Drawing.Size(147, 23)
		Me.btnDomingo.TabIndex = 4
		Me.btnDomingo.Text = "Agregar Día Domingo"
		Me.btnDomingo.UseVisualStyleBackColor = True
		'
		'btnJueves
		'
		Me.btnJueves.Location = New System.Drawing.Point(16, 45)
		Me.btnJueves.Name = "btnJueves"
		Me.btnJueves.Size = New System.Drawing.Size(147, 23)
		Me.btnJueves.TabIndex = 3
		Me.btnJueves.Text = "Agregar Día Jueves"
		Me.btnJueves.UseVisualStyleBackColor = True
		'
		'btnSabado
		'
		Me.btnSabado.Location = New System.Drawing.Point(16, 104)
		Me.btnSabado.Name = "btnSabado"
		Me.btnSabado.Size = New System.Drawing.Size(147, 23)
		Me.btnSabado.TabIndex = 2
		Me.btnSabado.Text = "Agregar Día Sabado"
		Me.btnSabado.UseVisualStyleBackColor = True
		'
		'btnViernes
		'
		Me.btnViernes.Location = New System.Drawing.Point(16, 74)
		Me.btnViernes.Name = "btnViernes"
		Me.btnViernes.Size = New System.Drawing.Size(147, 23)
		Me.btnViernes.TabIndex = 1
		Me.btnViernes.Text = "Agregar Día Viernes"
		Me.btnViernes.UseVisualStyleBackColor = True
		'
		'cbDias
		'
		Me.cbDias.FormattingEnabled = True
		Me.cbDias.Items.AddRange(New Object() {"Miércoles", "Martes", "Lunes"})
		Me.cbDias.Location = New System.Drawing.Point(16, 18)
		Me.cbDias.Name = "cbDias"
		Me.cbDias.Size = New System.Drawing.Size(121, 21)
		Me.cbDias.TabIndex = 0
		Me.cbDias.Text = "Seleccionar Día"
		'
		'tcInformeDieta
		'
		Me.tcInformeDieta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tcInformeDieta.Controls.Add(Me.btnInforme)
		Me.tcInformeDieta.Location = New System.Drawing.Point(4, 22)
		Me.tcInformeDieta.Name = "tcInformeDieta"
		Me.tcInformeDieta.Padding = New System.Windows.Forms.Padding(3)
		Me.tcInformeDieta.Size = New System.Drawing.Size(792, 301)
		Me.tcInformeDieta.TabIndex = 1
		Me.tcInformeDieta.Text = "Informe de la Dieta"
		Me.tcInformeDieta.UseVisualStyleBackColor = True
		'
		'tcEnsamblado
		'
		Me.tcEnsamblado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tcEnsamblado.Controls.Add(Me.btnEnsamblado)
		Me.tcEnsamblado.Location = New System.Drawing.Point(4, 22)
		Me.tcEnsamblado.Name = "tcEnsamblado"
		Me.tcEnsamblado.Padding = New System.Windows.Forms.Padding(3)
		Me.tcEnsamblado.Size = New System.Drawing.Size(792, 301)
		Me.tcEnsamblado.TabIndex = 2
		Me.tcEnsamblado.Text = "Ensamblado"
		Me.tcEnsamblado.UseVisualStyleBackColor = True
		'
		'btnEnsamblado
		'
		Me.btnEnsamblado.Location = New System.Drawing.Point(8, 7)
		Me.btnEnsamblado.Name = "btnEnsamblado"
		Me.btnEnsamblado.Size = New System.Drawing.Size(183, 23)
		Me.btnEnsamblado.TabIndex = 0
		Me.btnEnsamblado.Text = "Ensamblar semana 2"
		Me.btnEnsamblado.UseVisualStyleBackColor = True
		'
		'btnInforme
		'
		Me.btnInforme.Location = New System.Drawing.Point(8, 7)
		Me.btnInforme.Name = "btnInforme"
		Me.btnInforme.Size = New System.Drawing.Size(261, 113)
		Me.btnInforme.TabIndex = 0
		Me.btnInforme.Text = "Mostrar Informe"
		Me.btnInforme.UseVisualStyleBackColor = True
		'
		'frMDI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.tcIngresar)
		Me.Controls.Add(Me.MenuStrip1)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "frMDI"
		Me.Text = "Aplicaciones MDI"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.tcIngresar.ResumeLayout(False)
		Me.tcIngresarDieta.ResumeLayout(False)
		Me.tcComidas.ResumeLayout(False)
		Me.tpDesayuno.ResumeLayout(False)
		Me.tpDesayuno.PerformLayout()
		Me.tpAlmuerzo.ResumeLayout(False)
		Me.tpAlmuerzo.PerformLayout()
		Me.tpCena.ResumeLayout(False)
		Me.tpCena.PerformLayout()
		Me.tcInformeDieta.ResumeLayout(False)
		Me.tcEnsamblado.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents IngresarDietaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InformeDeDietaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EnsambladoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tcIngresar As TabControl
	Friend WithEvents tcIngresarDieta As TabPage
	Friend WithEvents tcInformeDieta As TabPage
	Friend WithEvents tcEnsamblado As TabPage
	Friend WithEvents cbDias As ComboBox
	Friend WithEvents btnJueves As Button
	Friend WithEvents btnSabado As Button
	Friend WithEvents btnViernes As Button
	Friend WithEvents btnDomingo As Button
	Friend WithEvents tcComidas As TabControl
	Friend WithEvents tpDesayuno As TabPage
	Friend WithEvents lbDesayunoC As ListBox
	Friend WithEvents lbDesayunoB As ListBox
	Friend WithEvents tpAlmuerzo As TabPage
	Friend WithEvents lbAlmuerzoC As ListBox
	Friend WithEvents lbAlmuerzoB As ListBox
	Friend WithEvents tpCena As TabPage
	Friend WithEvents lbCenaC As ListBox
	Friend WithEvents lbCenaB As ListBox
	Friend WithEvents lbComestible As Label
	Friend WithEvents lbBebestible As Label
	Friend WithEvents lbAcompañamiento As Label
	Friend WithEvents lbProteina As Label
	Friend WithEvents lbFruta As Label
	Friend WithEvents lbVerdura As Label
	Friend WithEvents btnEnsamblado As Button
	Friend WithEvents btnInforme As Button
End Class
