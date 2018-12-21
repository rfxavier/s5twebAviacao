Imports System.Drawing.Drawing2D
Imports System.Xml
Imports DevExpress.XtraEditors.Camera
Imports Microsoft.Win32
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Camera
Imports DevExpress.Utils

Public Class Form
    Dim objCadVisitante As S5T.VisitanteVisita = Nothing

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'S5taviacaoDataSet.VisitanteVisita' table. You can move, or remove it, as needed.
        'Me.VisitanteVisitaTableAdapter.Fill(Me.S5taviacaoDataSet.VisitanteVisita)

        Dim obj = S5T.VisitanteVisitaCollection.LoadAll

        cmbCadastroVisitante.Properties.DataSource = obj
        cmbCadastroVisitante.Properties.DisplayMember = "pNome"
        cmbCadastroVisitante.Properties.ValueMember = "pId"

    End Sub

    Private Sub cmbCadastroVisitante_KeyDown(sender As Object, e As KeyEventArgs)
        If cmbCadastroVisitante.EditValue <> Nothing Then
            If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
                cmbCadastroVisitante.EditValue = Nothing
            End If
        End If
    End Sub




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

End Class