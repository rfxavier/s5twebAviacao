Imports System.Drawing.Drawing2D
Imports System.Xml
Imports DevExpress.XtraEditors.Camera
Imports Microsoft.Win32
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Camera
Imports DevExpress.Utils
Imports CodeFluent.Runtime
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization


Public Class Form
    Dim objCadVisitante As S5T.VisitanteVisita = Nothing
    Dim pIdEmpresa As Long
    Dim pIdVisitante As Long
    Dim pIdVisita As Long

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      


        For Each cdi As CameraDeviceInfo In CameraControl.GetDevices()
            cmbCamera.Properties.Items.Add(cdi.Name)
        Next

        VerificaChaveServer()


        If txtCaminhoSalvar.EditValue = Nothing Then
            txtCaminhoSalvar.EditValue = "\\192.168.50.39\ImagensWebCam\"
        End If


        '********** TELA DE CADASTRO DE VISITANTE ****************************8
        cmbSexo.Properties.Items.Clear()
        cmbSexo.Properties.Items.Add("FEMININO")
        cmbSexo.Properties.Items.Add("MASCULINO")

        cmbCidade.Properties.DataSource = S5T.CidadeCollection.LoadAll
        cmbCidade.Properties.DisplayMember = "pNome"
        cmbCidade.Properties.ValueMember = "pId"
        '********** FIM CADASTRO DE VISITANTE


        '************* TELA DE MOVMENTAÇÃO DA VISITA ******************************
        LinqServerModeSourceSetor.KeyExpression = "pId"
        LinqServerModeSourceSetor.QueryableSource = New S5TWebCam.DataClassesSetorVisitaDataContext().SetorVisitas
        cmbVisitaSetor.Properties.DataSource = LinqServerModeSourceSetor
        cmbVisitaSetor.Properties.DisplayMember = "pNome"
        cmbVisitaSetor.Properties.ValueMember = "pId"

        LinqServerModeSourceFuncionario.KeyExpression = "pId"
        LinqServerModeSourceFuncionario.QueryableSource = New S5TWebCam.DataClassesFuncionarioVisitaDataContext().FuncionarioVisitas
        cmbVisitaVisitante.Properties.DataSource = LinqServerModeSourceFuncionario
        cmbVisitaVisitante.Properties.DisplayMember = "pNome"
        cmbVisitaVisitante.Properties.ValueMember = "pId"

        LinqServerModeSourceEmpresa.KeyExpression = "pId"
        LinqServerModeSourceEmpresa.QueryableSource = New S5TWebCam.DataClassesEmpresaVisitaDataContext().EmpresaVisitas
        cmbVisitaVisitante.Properties.DataSource = LinqServerModeSourceEmpresa
        cmbVisitaVisitante.Properties.DisplayMember = "pNome"
        cmbVisitaVisitante.Properties.ValueMember = "pId"

        LinqServerModeSourceVisitante.KeyExpression = "pId"
        LinqServerModeSourceVisitante.QueryableSource = New S5TWebCam.DataClassesCadastroVisitanteDataContext().VisitanteVisitas
        cmbVisitaVisitante.Properties.DataSource = LinqServerModeSourceVisitante
        cmbVisitaVisitante.Properties.DisplayMember = "pNome"
        cmbVisitaVisitante.Properties.ValueMember = "pId"

        txtVisitaDataMov.EditValue = Date.Now


        LinqServerModeSourceVisitaView.KeyExpression = "pId"
        LinqServerModeSourceVisitaView.QueryableSource = New S5TWebCam.DataClassesVisitaMovViewGridDataContext().vVisitaMovVisitaViewGrids.OrderByDescending(Function(x) x.pDataVisita)
        '************* FIM VISITA ***************************

        TabPanePrincipal.SelectedPage = tabCadVisita

    End Sub

    'Private Sub cmbCidade_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCidade.KeyDown
    '    If cmbCidade.EditValue <> Nothing Then
    '        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
    '            cmbCidade.EditValue = Nothing
    '        End If
    '    End If
    'End Sub



    'Private Sub cmbCadastroVisitante_EditValueChanged(sender As Object, e As EventArgs)
    '    Try

    '        Dim fs As System.IO.FileStream ' Specify a valid picture file path on your computer.
    '        fs = New System.IO.FileStream(txtCaminhoSalvar.EditValue.ToString & cmbCadastroVisitante.EditValue.ToString & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
    '        Foto.Image = System.Drawing.Image.FromStream(fs)
    '        fs.Close()

    '        'Foto.Image = Image.FromFile(txtCaminhoSalvar.EditValue.ToString & cmbCadastroVisitante.EditValue.ToString & ".jpg")

    '    Catch ex As Exception
    '        Dim semFoto As System.IO.FileStream ' Specify a valid picture file path on your computer.
    '        semFoto = New System.IO.FileStream(txtCaminhoSalvar.EditValue.ToString & "semFoto.jpg", IO.FileMode.Open, IO.FileAccess.Read)
    '        Foto.Image = System.Drawing.Image.FromStream(semFoto)
    '        semFoto.Close()
    '        'Foto.Image = Image.FromFile(txtCaminhoSalvar.EditValue.ToString & "semFoto.jpg")
    '    End Try
    'End Sub

    Private Sub btnSalvarAlteracoes_Click(sender As Object, e As EventArgs) Handles btnSalvarAlteracoes.Click
        Try
            If txtCaminhoSalvar.EditValue.ToString.Trim <> String.Empty And cmbCamera.EditValue.ToString.Trim <> String.Empty Then

                ' Cria uma nova chave sob  HKEY_CURRENT_USER\Software
                Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", True)
                ' Inclui mais uma sub chave
                Dim newkey As RegistryKey = key.CreateSubKey("4TSistemas\\WebCam")
                ' Atirbui o valor para a sub chave
                newkey.SetValue("CAMINHO_FOTOS", txtCaminhoSalvar.EditValue)

                Dim newkeyCam As RegistryKey = key.CreateSubKey("4TSistemas\\WebCam")
                newkeyCam.SetValue("CAMERA_WEB", cmbCamera.EditValue)

                ' Atirbui o valor para a sub chave

                'Application.Restart()
            Else
                MsgBox("Caminho ou camera não pode ser Nulo.", vbInformation)
                txtCaminhoSalvar.Focus()
            End If

            MsgBox("Alterações realizadas com sucesso!", vbInformation, "Mensagem do Sistema.")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function VerificaChaveServer() As Boolean
        ' Retorna dados de um registro
        Try

            Dim pRegKey As RegistryKey = Registry.CurrentUser
            pRegKey = pRegKey.OpenSubKey("SOFTWARE\\4TSistemas\\WebCam")
            Dim val As Object = pRegKey.GetValue("CAMINHO_FOTOS")

            If val <> String.Empty Then
                txtCaminhoSalvar.EditValue = val
            End If

            Dim valCam As Object = pRegKey.GetValue("CAMERA_WEB")

            If valCam <> String.Empty Then
                cmbCamera.EditValue = valCam
            End If

            Return True

        Catch ex As System.NullReferenceException
            Return False
        End Try

        Return False
    End Function

    'Private Sub Form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If (Me.WindowState = FormWindowState.Minimized) Then
    '        Me.Hide()
    '    End If
    'End Sub

    'Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Me.Show()
    '    Me.WindowState = FormWindowState.Minimized

    '    If e.Button = System.Windows.Forms.MouseButtons.Right Then
    '        ContextMenuStrip1.Show(e.Location)
    '    End If
    'End Sub




    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub




    Private Sub btnSalvarEmpresa_Click(sender As Object, e As EventArgs) Handles btnSalvarEmpresa.Click
        Try

            If pIdEmpresa = 0 Then
                Dim obj As New S5T.EmpresaVisita

                With obj
                    .pNome = txtNomeEmpresa.EditValue
                    .Save()
                End With

            Else
                Dim obj As S5T.EmpresaVisita
                obj = S5T.EmpresaVisita.LoadBypId(pIdEmpresa)

                With obj
                    .pNome = txtNomeEmpresa.EditValue
                    .Save()
                End With

            End If

            txtNomeEmpresa.EditValue = Nothing
        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode
            MsgBox(msgEx, vbInformation, "Mensagem do Sistema")
        End Try

    End Sub

    Private Sub btnExcluirEmpresa_Click(sender As Object, e As EventArgs) Handles btnExcluirEmpresa.Click
        If pIdEmpresa <> 0 Then
            If MsgBox("Deseja excluir o registro atual?", vbYesNo, "Mensagem do Sistema") = vbYes Then
                Try
                    S5T.EmpresaVisita.Delete(S5T.EmpresaVisita.LoadByEntityKey(pIdEmpresa))
                Catch ex As CodeFluentValidationException
                    MsgBox(ex.MessageWithoutCode, vbInformation, "Mensagem do Sistema")
                End Try
            End If

            txtNomeEmpresa.EditValue = Nothing
            pIdEmpresa = 0
        End If

    End Sub




    Private Sub GridEmpresa_DoubleClick(sender As Object, e As EventArgs) Handles GridEmpresa.DoubleClick
        If GridViewEmpresa.SelectedRowsCount = 1 And GridViewEmpresa.IsDataRow(GridViewEmpresa.FocusedRowHandle) Then

            Dim Obj = S5T.EmpresaVisita.LoadByEntityKey(GridViewEmpresa.GetRowCellValue(GridViewEmpresa.FocusedRowHandle, GridViewEmpresa.Columns.ColumnByFieldName("pId")))

            pIdEmpresa = Obj.pId
            txtNomeEmpresa.EditValue = Obj.pNome

        End If

    End Sub

    Private Sub btnWebCam_Click(sender As Object, e As EventArgs) Handles btnWebCam.Click

        Dim oForm As New FormWebCam

        If oForm.ShowDialog = DialogResult.OK Then
            Foto.Image = Nothing

            Dim i As Image = oForm.CameraControl1.TakeSnapshot

            Dim newimage As Image = New Bitmap(320, 240)
            Using graphicshandle As Graphics = Graphics.FromImage(newimage)
                graphicshandle.InterpolationMode = InterpolationMode.HighQualityBicubic
                graphicshandle.DrawImage(i, 0, 0, 320, 240)
            End Using

            Foto.Image = newimage


        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvarVisitante.Click

        Try

            If pIdVisitante = 0 Then
                Dim obj As New S5T.VisitanteVisita

                With obj
                    .pNome = txtNome.EditValue
                    .pHabilitacao = txtNumHabilitacao.EditValue
                    .pCpfCnpj = txtCPF.EditValue
                    .pRg = txtRG.EditValue
                    .pTelefoneFixo = txtTelefone.EditValue
                    .pTelefoneCelular = txtCelular.EditValue
                    .pEnderLogradouro = txtEndereco.EditValue
                    .pEnderNumero = txtNumero.EditValue
                    .pEnderComplemento = txtComplemento.EditValue
                    .pEnderBairro = txtBairro.EditValue
                    .pEnderCep = txtCEP.EditValue
                    .pSexo = cmbSexo.EditValue
                    .oCidadepId = cmbCidade.EditValue

                    .Save()
                End With

                'salvando a foto
                Dim i As Image = Foto.Image

                If i IsNot Nothing Then

                    Dim newimage As Image = New Bitmap(320, 240)
                    Using graphicshandle As Graphics = Graphics.FromImage(newimage)
                        graphicshandle.InterpolationMode = InterpolationMode.HighQualityBicubic
                        graphicshandle.DrawImage(i, 0, 0, 320, 240)

                    End Using
                    newimage.Save(txtCaminhoSalvar.EditValue.ToString & obj.pId.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                End If

                MsgBox("Registro salvo com sucesso!", vbInformation, "Mensagem do sistema")
                Foto.Image = Nothing

            Else
                Dim obj As S5T.VisitanteVisita
                obj = S5T.VisitanteVisita.LoadBypId(pIdVisitante)

                With obj
                    .pNome = txtNome.EditValue
                    .pHabilitacao = txtNumHabilitacao.EditValue
                    .pCpfCnpj = txtCPF.EditValue
                    .pRg = txtRG.EditValue
                    .pTelefoneFixo = txtTelefone.EditValue
                    .pTelefoneCelular = txtCelular.EditValue
                    .pEnderLogradouro = txtEndereco.EditValue
                    .pEnderNumero = txtNumero.EditValue
                    .pEnderComplemento = txtComplemento.EditValue
                    .pEnderBairro = txtBairro.EditValue
                    .pEnderCep = txtCEP.EditValue
                    .pSexo = cmbSexo.EditValue
                    .oCidadepId = cmbCidade.EditValue
                    .Save()
                End With

                'salvando a foto
                Dim i As Image = Foto.Image

                Dim newimage As Image = New Bitmap(320, 240)
                Using graphicshandle As Graphics = Graphics.FromImage(newimage)
                    graphicshandle.InterpolationMode = InterpolationMode.HighQualityBicubic
                    graphicshandle.DrawImage(i, 0, 0, 320, 240)

                End Using
                newimage.Save(txtCaminhoSalvar.EditValue.ToString & obj.pId.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

                MsgBox("Registro salvo com sucesso!", vbInformation, "Mensagem do sistema")
                Foto.Image = Nothing

            End If

            LimpaCampoVisitante()
        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode
            MsgBox(msgEx, vbInformation, "Mensagem do Sistema")
        End Try

    End Sub

    Public Sub LimpaCampoVisitante()
        pIdVisitante = Nothing
        txtNome.EditValue = Nothing
        txtNumHabilitacao.EditValue = Nothing
        txtCPF.EditValue = Nothing
        txtRG.EditValue = Nothing
        txtTelefone.EditValue = Nothing
        txtCelular.EditValue = Nothing
        txtEndereco.EditValue = Nothing
        txtNumero.EditValue = Nothing
        txtComplemento.EditValue = Nothing
        txtBairro.EditValue = Nothing
        txtCEP.EditValue = Nothing

        cmbSexo.EditValue = Nothing
        cmbCidade.EditValue = Nothing

        txtNome.Focus()
    End Sub

    Public Sub LimpaCampoVisita()
        pIdVisita = Nothing
        txtVisitaDataMov.EditValue = Date.Now
        cmbVisitaVisitante.EditValue = Nothing
        cmbVisitaEmpresa.EditValue = Nothing
        cmbVisitaFuncionario.EditValue = Nothing
        cmbVisitaSetor.EditValue = Nothing

        cmbVisitaVisitante.Focus()
    End Sub

    Public Sub ImprimeEtiquetaVisita(ByVal parIdVisitaMov As Long)

        Dim oRelatorio As New repEtiqueta

        Dim VisitaMov = S5T.VisitaMovCollection.LoadByIdViewGrid(parIdVisitaMov)

        oRelatorio.DataSource = VisitaMov
        oRelatorio.CreateDocument()

        FormReportDX.DocumentViewer1.DocumentSource = oRelatorio


        ' THIS IS TO TAKE THE DEFAULT LOCAL PRINT
        Dim instance As New Printing.PrinterSettings
        Dim DefaultPrinter As String = instance.PrinterName

        ' THIS IS TO PRINT THE REPORT
        oRelatorio.PrinterName = DefaultPrinter
        oRelatorio.CreateDocument()
        oRelatorio.PrintingSystem.ShowMarginsWarning = False
        oRelatorio.Print()


    End Sub
    Private Sub GridVisitante_DoubleClick(sender As Object, e As EventArgs) Handles GridVisitante.DoubleClick
        Try
            If GridViewVisitante.SelectedRowsCount = 1 And GridViewVisitante.IsDataRow(GridViewVisitante.FocusedRowHandle) Then

                Dim Obj = S5T.VisitanteVisita.LoadByEntityKey(GridViewVisitante.GetRowCellValue(GridViewVisitante.FocusedRowHandle, GridViewVisitante.Columns.ColumnByFieldName("pId")))

                pIdVisitante = Obj.pId
                txtNome.Text = Obj.pNome
                txtNumHabilitacao.Text = Obj.pHabilitacao
                txtCPF.Text = Obj.pCpfCnpj
                txtRG.Text = Obj.pRg
                txtTelefone.Text = Obj.pTelefoneFixo
                txtCelular.Text = Obj.pTelefoneCelular
                txtEndereco.Text = Obj.pEnderLogradouro
                txtNumero.Text = Obj.pEnderNumero
                txtComplemento.Text = Obj.pEnderComplemento
                txtBairro.Text = Obj.pEnderBairro
                txtCEP.Text = Obj.pEnderCep

                If Obj.pSexo IsNot Nothing Then
                    cmbSexo.EditValue = Obj.pSexo
                End If

                If Obj.oCidade IsNot Nothing Then
                    'cmbCidade.SelectedIndex = cmbCidade.Items.IndexOf(cmbCidade.Items.FindByText(obj.oCidade.pNome))
                    'Dim result = cmbCidade.Items.Cast(Of ComboBoxItem)().Where(Function(i) (Integer.Parse(i.Value.ToString())) = obj.oCidadepId)
                    cmbCidade.EditValue = Obj.oCidadepId
                End If


                Dim fs As System.IO.FileStream ' Specify a valid picture file path on your computer.
                fs = New System.IO.FileStream(txtCaminhoSalvar.EditValue.ToString & Obj.pId.ToString & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
                Foto.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()

                TabPane2.SelectedPage = TabNavigationPage2

            End If

            'Foto.Image = Image.FromFile(txtCaminhoSalvar.EditValue.ToString & cmbCadastroVisitante.EditValue.ToString & ".jpg")

        Catch ex As Exception
            Dim semFoto As System.IO.FileStream ' Specify a valid picture file path on your computer.
            semFoto = New System.IO.FileStream(txtCaminhoSalvar.EditValue.ToString & "semFoto.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            Foto.Image = System.Drawing.Image.FromStream(semFoto)
            semFoto.Close()
            TabPane2.SelectedPage = TabNavigationPage2

            'Foto.Image = Image.FromFile(txtCaminhoSalvar.EditValue.ToString & "semFoto.jpg")
        End Try
    End Sub

    Private Sub btnLimparVisitante_Click(sender As Object, e As EventArgs) Handles btnLimparVisitante.Click
        LimpaCampoVisitante()
    End Sub

    Private Sub btnLimparEmpresa_Click(sender As Object, e As EventArgs) Handles btnLimparEmpresa.Click
        txtNomeEmpresa.EditValue = Nothing
    End Sub

    Private Sub btnVisitaSalvar_Click(sender As Object, e As EventArgs) Handles btnVisitaSalvar.Click
        Try

            If pIdVisita = 0 Then
                Dim obj As New S5T.VisitaMov

                With obj
                    .pDataVisita = txtVisitaDataMov.EditValue
                    .oVisitantepId = cmbVisitaVisitante.EditValue
                    .oEmpresapId = cmbVisitaEmpresa.EditValue
                    .oFuncionariopId = cmbVisitaFuncionario.EditValue
                    .oSetorpId = cmbVisitaSetor.EditValue
                    .Save()
                End With

                Dim Visitante As S5T.VisitanteVisita
                Visitante = S5T.VisitanteVisita.LoadByEntityKey(cmbVisitaVisitante.EditValue)
                
                If Visitante.pCpfCnpj IsNot Nothing Then
              
                    'gravação dos dados do Visitante na base da TekaRadius
                    Dim query As String = String.Empty
                    query &= "INSERT INTO Users (UserName, Attribute, AttrType,Val) VALUES (@UserName,@Attribute1, @AttrType, @Val); "
                    query &= "INSERT INTO Users (UserName, Attribute, AttrType,Val) VALUES (@UserName,@Attribute0, @AttrType, @Val0); "
                    query &= "INSERT INTO Users (UserName, Attribute, AttrType,Val) VALUES (@UserName,@Attribute2, @AttrType, @Val); "

                    Using conn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("TekaRadiusConnectionString").ConnectionString)
                    
                        Using comm As New SqlCommand()
                            With comm
                                .Connection = conn
                                .CommandType = CommandType.Text
                                .CommandText = query
                                .Parameters.AddWithValue("@UserName", Replace(Replace(Visitante.pCpfCnpj,".",""),"-",""))
                                .Parameters.AddWithValue("@Attribute1", "ietf|1")
                                .Parameters.AddWithValue("@Attribute0", "ietf|0")
                                .Parameters.AddWithValue("@Attribute2", "ietf|2")
                                .Parameters.AddWithValue("@AttrType", 0)
                                .Parameters.AddWithValue("@Val", Replace(Replace(Visitante.pCpfCnpj,".",""),"-",""))
                                .Parameters.AddWithValue("@Val0", "Visitante")
                                                                           
                            End With
                            Try
                                conn.Open()
                                comm.ExecuteNonQuery()
                            Catch ex As SqlException
                                MessageBox.Show(ex.Message.ToString(), "Error Message")
                            End Try
                        End Using
                    End Using
                End If
                
                'fim gravação dos dados

                ImprimeEtiquetaVisita(obj.pId)
            Else
                Dim obj As S5T.VisitaMov
                obj = S5T.VisitaMov.LoadBypId(pIdVisita)

                With obj
                    .oVisitantepId = cmbVisitaVisitante.EditValue
                    .oEmpresapId = cmbVisitaEmpresa.EditValue
                    .oFuncionariopId = cmbVisitaFuncionario.EditValue
                    .oSetorpId = cmbVisitaSetor.EditValue
                    .Save()
                End With

                ImprimeEtiquetaVisita(obj.pId)
            End If

            LimpaCampoVisita()
        Catch ex As CodeFluentValidationException
            Dim msgEx As String = ex.MessageWithoutCode
            MsgBox(msgEx, vbInformation, "Mensagem do Sistema")
        End Try

    End Sub

    Private Sub cmbVisitaVisitante_EditValueChanged(sender As Object, e As EventArgs) Handles cmbVisitaVisitante.EditValueChanged
        If cmbVisitaVisitante.EditValue IsNot Nothing Then
            Dim obj = S5T.VisitaMov.LoadUltimaVisitaVisitante(cmbVisitaVisitante.EditValue)

            If obj IsNot Nothing Then
                cmbVisitaEmpresa.EditValue = obj.oEmpresapId
                cmbVisitaFuncionario.EditValue = obj.oFuncionariopId
                cmbVisitaSetor.EditValue = obj.oSetorpId
            End If
        Else
            cmbVisitaEmpresa.EditValue = Nothing
            cmbVisitaFuncionario.EditValue = Nothing
            cmbVisitaSetor.EditValue = Nothing
        End If
    End Sub

    Private Sub btnVisitaExcluir_Click(sender As Object, e As EventArgs) Handles btnVisitaExcluir.Click
        If pIdVisita <> 0 Then
            If MsgBox("Deseja excluir o registro atual?", vbYesNo, "Mensagem do Sistema") = vbYes Then
                Try
                    S5T.VisitaMov.Delete(S5T.VisitaMov.LoadByEntityKey(pIdVisita))
                Catch ex As CodeFluentValidationException
                    MsgBox(ex.MessageWithoutCode, vbInformation, "Mensagem do Sistema")
                End Try
            End If

            LimpaCampoVisita()
            pIdVisita = 0
        End If
    End Sub

    Private Sub btnExcluirVisitante_Click(sender As Object, e As EventArgs) Handles btnExcluirVisitante.Click
        If pIdVisitante <> 0 Then
            If MsgBox("Deseja excluir o registro atual?", vbYesNo, "Mensagem do Sistema") = vbYes Then
                Try
                    S5T.VisitanteVisita.Delete(S5T.VisitanteVisita.LoadByEntityKey(pIdVisitante))
                Catch ex As CodeFluentValidationException
                    MsgBox(ex.MessageWithoutCode, vbInformation, "Mensagem do Sistema")
                End Try
            End If

            LimpaCampoVisitante()
            pIdVisitante = 0
        End If
    End Sub

    Private Sub GridVisita_DoubleClick(sender As Object, e As EventArgs) Handles GridVisita.DoubleClick
        Try
            If GridViewVisita.SelectedRowsCount = 1 And GridViewVisita.IsDataRow(GridViewVisita.FocusedRowHandle) Then

                Dim Obj = S5T.VisitaMov.LoadByEntityKey(GridViewVisita.GetRowCellValue(GridViewVisita.FocusedRowHandle, GridViewVisita.Columns.ColumnByFieldName("pId")))

                pIdVisita = Obj.pId
                txtVisitaDataMov.EditValue = Obj.pDataVisita
                cmbVisitaVisitante.EditValue = Obj.oVisitantepId
                cmbVisitaEmpresa.EditValue = Obj.oEmpresapId
                cmbVisitaFuncionario.EditValue = Obj.oFuncionariopId
                cmbVisitaSetor.EditValue = Obj.oSetorpId

                TabPane3.SelectedPage = tabPageVisitaDados

            End If

        Catch ex As Exception
            TabPane3.SelectedPage = tabPageVisitaDados

        End Try
    End Sub

    Private Sub btnVisitaImprimir_Click(sender As Object, e As EventArgs) Handles btnVisitaImprimir.Click
        If pIdVisita <> 0 Then

            ImprimeEtiquetaVisita(pIdVisita)
        End If
    End Sub

    Private Sub btnVisitaCancelar_Click(sender As Object, e As EventArgs) Handles btnVisitaCancelar.Click
        LimpaCampoVisita()
    End Sub
End Class