Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports CodeFluent.Runtime

Imports DevExpress.Utils.Menu
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports System.Net.Mail
Imports System.IO

Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin

Imports System.Linq
Imports System.Web
Imports System.Xml.Linq
Imports DevExpress.XtraPrinting

Public Class FormEnvioEmail
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnviaDashProdutosTerceiros()
        EnviaEmailTodosDahsGerenciais()
        EnviaSomente1DahsGerencial()
        EnviaRelatorioProducaoDiarioMVC
        EnviaRelatorioOrdensErroProtheus
        EnviaRelatorioVendasVendedor()

        me.Close()
    End Sub

    Public Sub EnviaEmailTodosDahsGerenciais()
        Dim viewer As New DevExpress.DashboardWin.DashboardViewer

        AddHandler viewer.ConfigureDataConnection, AddressOf DashboardViewerEmail_ConfigureDataConnection
        Dim caminhoXml As String
        Dim nomeXmlDash As String


        If Now.Day = "01" Then
            caminhoXml = "C:\Sistemas\s5t aviacao\S5TEnviaEmail\xmlDash\"
            nomeXmlDash = "dashindicadoresEMAILDia01.xml"
        Else
            caminhoXml = "C:\Sistemas\s5t aviacao\S5TEnviaEmail\xmlDash\"
            nomeXmlDash = "dashindicadoresEMAIL.xml"
        End If

        viewer.LoadDashboard(caminhoXml & nomeXmlDash)

        ''exported document layout depend on the viewer size
        viewer.Height = 4500
        viewer.Width = 2850
        'If Now.DayOfWeek = DayOfWeek.Monday Then
        '    viewer.Dashboard.Title.Text = " Indic. Vendas Laticínios (" & Now.Date.AddDays(-3) & ")"
        'Else
        '    viewer.Dashboard.Title.Text = " Indic. Vendas Laticínios (" & Now.Date.AddDays(-1) & ")"
        'End If

        viewer.Dashboard.Title.Text = " Indic. Vendas Laticínios (" & Now.Date & ")"


        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Calibri", 2)
        viewer.Appearance.Font = New Font("Calibri", 2)

        Dim MemRecibo As New MemoryStream()
        viewer.ExportToPdf(MemRecibo)

        '******************** anexo 2

        Dim viewer2 As New DevExpress.DashboardWin.DashboardViewer

        AddHandler viewer2.ConfigureDataConnection, AddressOf DashboardViewerEmail_ConfigureDataConnection
        Dim caminhoXml2 As String
        Dim nomeXmlDash2 As String


        If Now.Day = "01" Then
            caminhoXml2 = "C:\Sistemas\s5t aviacao\S5TEnviaEmail\xmlDash\"
            nomeXmlDash2 = "dashindicadoresCafeEMAILDia01.xml"
        Else
            caminhoXml2 = "C:\Sistemas\s5t aviacao\S5TEnviaEmail\xmlDash\"
            nomeXmlDash2 = "dashindicadoresCafeEMAILDia.xml"
        End If



        viewer2.LoadDashboard(caminhoXml2 & nomeXmlDash2)

        ''exported document layout depend on the viewer size
        viewer2.Height = 4000
        viewer2.Width = 2500
        'If Now.DayOfWeek = DayOfWeek.Monday Then
        '    viewer2.Dashboard.Title.Text = " Indic. Vendas Café (" & Now.Date.AddDays(-3) & ")"
        'Else
        '    viewer2.Dashboard.Title.Text = " Indic. Vendas Café (" & Now.Date.AddDays(-1) & ")"
        'End If
        viewer2.Dashboard.Title.Text = " Indic. Vendas Café (" & Now.Date & ")"


        viewer2.Appearance.Font = New Font("Calibri", 2)
        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Calibri", 2)

        Dim MemRecibo2 As New MemoryStream()
        viewer2.ExportToPdf(MemRecibo2)



        '******************** anexo 3

        Dim viewer3 As New DevExpress.DashboardWin.DashboardViewer

        'AddHandler viewer3.ConfigureDataConnection, AddressOf DashboardViewerEmail_ConfigureDataConnectionOracle

        AddHandler viewer3.DataLoading, AddressOf DashboardViewerEmail_DataLoading


        Dim caminhoXml3 = "C:\Sistemas\s5t aviacao\S5TEnviaEmail\xmlDash\"
        'Dim nomeXmlDash3 = "dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutroEmail.xml"
        Dim nomeXmlDash3 = "dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutroObjDs.xml"
        viewer3.LoadDashboard(caminhoXml3 & nomeXmlDash3)

        ''exported document layout depend on the viewer size
        viewer3.Height = 4500
        viewer3.Width = 2850
        viewer3.Dashboard.Title.Text = " Prod. X Pedidos (" & Now.Date & ")"

        viewer3.Appearance.Font = New Font("Calibri", 2)
        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Calibri", 2)

        Dim MemRecibo3 As New MemoryStream()
        viewer3.ExportToPdf(MemRecibo3)


        'envio de email com o pdf
        ' Create a new memory stream and export the report into it as PDF.
        'oRelatorio.ExportToPdf(MemRecibo, optionsRecibo)

        ' Create a new attachment and put the PDF report into it.
        MemRecibo.Seek(0, System.IO.SeekOrigin.Begin)
        MemRecibo2.Seek(0, System.IO.SeekOrigin.Begin)
        MemRecibo3.Seek(0, System.IO.SeekOrigin.Begin)
        'Dim AttRecibo = New Attachment(MemRecibo, "Indicadores de vendas LATICÍNIOS - " & Date.Now & ".pdf", "application/pdf")
        'Dim AttRecibo2 = New Attachment(MemRecibo2, "Indicadores de vendas CAFÉ - " & Date.Now & ".pdf", "application/pdf")
        'Dim AttRecibo3 = New Attachment(MemRecibo3, "Produção X Pedidos - " & Date.Now & ".pdf", "application/pdf")

        Dim AttRecibo = New Attachment(MemRecibo, "Indicadores de vendas LATICÍNIOS.pdf", "application/pdf")
        Dim AttRecibo2 = New Attachment(MemRecibo2, "Indicadores de vendas CAFÉ.pdf", "application/pdf")
        Dim AttRecibo3 = New Attachment(MemRecibo3, "Produção X Pedidos.pdf", "application/pdf")


        'Dim AttRecibo = New Attachment(MemRecibo, "Indicadores de vendas - " & MonthName(Date.Now.Month) & ".pdf", "application/pdf")
        ' Create a new message and attach the PDF report to it.
        Dim Mail As New MailMessage()
        Mail.Attachments.Add(AttRecibo)
        Mail.Attachments.Add(AttRecibo2)
        Mail.Attachments.Add(AttRecibo3)

        ' Specify sender and recipient options for the e-mail message.
        'Mail.From = New MailAddress("workflow@laticiniosaviacao.com.br", "B.I Aviação")
        Mail.From = New MailAddress("bi@aviacao.ind.br", "B.I Aviação")

        Mail.Bcc.Add(New MailAddress("ssilveira1977@gmail.com"))
        Mail.Bcc.Add(New MailAddress("luizguilherme@4tsistemas.com.br"))

        Mail.To.Add(New MailAddress("roberto@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("geraldo@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("ana@laticiniosaviacao.com.br"))

        Mail.To.Add(New MailAddress("paula@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("marina@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("luciana@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("armando@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("marcelo@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("fani@laticiniosaviacao.com.br"))

        'email com copia oculta para matheus
        Mail.Bcc.Add(New MailAddress("matheus@laticiniosaviacao.com.br"))

        ' Specify other e-mail options.
        'Mail.Subject = "INDICADORES DE VENDA - " & CStr(Date.Now) & ""
        Mail.Subject = "INDICADORES DE VENDA"
        Mail.Body = "E-mail automático enviado da plataforma 4TBI - NÃO RESPONDER ESSE E-MAIL"

        '' Send the e-mail message via the specified SMTP server.
        Dim Smtp = New SmtpClient("mail.aviacao.ind.br")
        Smtp.Port = 587
        Smtp.Credentials = New System.Net.NetworkCredential("bi@aviacao.ind.br", "200920")
        Smtp.EnableSsl = True

        'Dim Smtp = New SmtpClient("smtp.gmail.com")
        'Smtp.Port = 587
        'Smtp.Credentials = New System.Net.NetworkCredential("workflow@laticiniosaviacao.com.br", "200920")
        'Smtp.EnableSsl = True

        'Dim Smtp = New SmtpClient("smtp.gmail.com")
        'Smtp.Port = 587
        'Smtp.Credentials = New System.Net.NetworkCredential("faturamentoacissp@gmail.com", "Acissp1350")
        'Smtp.EnableSsl = True


        Smtp.Send(Mail)

        ' Close the memory stream.
        MemRecibo.Close()
        MemRecibo2.Close()
        MemRecibo3.Close()

        'Me.Close()
    End Sub


    Public Sub EnviaSomente1DahsGerencial()


        '******************** anexo 3

        Dim viewer3 As New DevExpress.DashboardWin.DashboardViewer

        AddHandler viewer3.DataLoading, AddressOf DashboardViewerEmail_DataLoading

        Dim caminhoXml3 = "C:\Sistemas\s5t aviacao\S5TEnviaEmail\xmlDash\"
        Dim nomeXmlDash3 = "dashCnProducaoProducaoPedidoSemDetalheCimaBaixoNeutroObjDs.xml"


        viewer3.LoadDashboard(caminhoXml3 & nomeXmlDash3)

        ''exported document layout depend on the viewer size
        viewer3.Height = 4000
        viewer3.Width = 2500
        viewer3.Dashboard.Title.Text = " Prod. X Pedidos (" & Now.Date & ")"

        viewer3.Appearance.Font = New Font("Calibri", 2)
        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Calibri", 2)

        Dim MemRecibo3 As New MemoryStream()
        viewer3.ExportToPdf(MemRecibo3)


        'envio de email com o pdf
        ' Create a new memory stream and export the report into it as PDF.
        'oRelatorio.ExportToPdf(MemRecibo, optionsRecibo)

        ' Create a new attachment and put the PDF report into it.

        MemRecibo3.Seek(0, System.IO.SeekOrigin.Begin)

        Dim AttRecibo3 = New Attachment(MemRecibo3, "Produção X Pedidos.pdf", "application/pdf")

        Dim Mail As New MailMessage()
        Mail.Attachments.Add(AttRecibo3)

        ' Specify sender and recipient options for the e-mail message.
        'Mail.From = New MailAddress("workflow@laticiniosaviacao.com.br", "B.I Aviação")
        Mail.From = New MailAddress("bi@aviacao.ind.br", "B.I Aviação")

        Mail.Bcc.Add(New MailAddress("ssilveira1977@gmail.com"))
        Mail.Bcc.Add(New MailAddress("luizguilherme@4tsistemas.com.br"))

        Mail.To.Add(New MailAddress("gerencia@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("julio@aviacao.ind.br"))

        'email com copia oculta para matheus
        Mail.Bcc.Add(New MailAddress("matheus@laticiniosaviacao.com.br"))

        ' Specify other e-mail options.
        'Mail.Subject = "INDICADORES DE VENDA - " & CStr(Date.Now) & ""
        Mail.Subject = "INDICADORES DE VENDA"
        Mail.Body = "E-mail automático enviado da plataforma 4TBI - NÃO RESPONDER ESSE E-MAIL"

        '' Send the e-mail message via the specified SMTP server.
        Dim Smtp = New SmtpClient("mail.aviacao.ind.br")
        Smtp.Port = 587
        Smtp.Credentials = New System.Net.NetworkCredential("bi@aviacao.ind.br", "200920")
        Smtp.EnableSsl = True


        'Dim Smtp = New SmtpClient("smtp.gmail.com")
        'Smtp.Port = 587
        'Smtp.Credentials = New System.Net.NetworkCredential("workflow@laticiniosaviacao.com.br", "200920")
        'Smtp.EnableSsl = True



        'Dim Smtp = New SmtpClient("smtp.gmail.com")
        'Smtp.Port = 587
        'Smtp.Credentials = New System.Net.NetworkCredential("faturamentoacissp@gmail.com", "Acissp1350")
        'Smtp.EnableSsl = True

        Smtp.Send(Mail)

        ' Close the memory stream.

        MemRecibo3.Close()

        'Me.Close()
    End Sub
    Public Sub EnviaDashProdutosTerceiros()


        '******************** anexo 3

        Dim viewer3 As New DevExpress.DashboardWin.DashboardViewer

        AddHandler viewer3.DataLoading, AddressOf DashboardViewerEmail_DataLoading

        Dim caminhoXml3 = "C:\Sistemas\s5t aviacao\S5TEnviaEmail\xmlDash\"
        Dim nomeXmlDash3 = "dashEstoqueTerceiros.xml"


        viewer3.LoadDashboard(caminhoXml3 & nomeXmlDash3)

        ''exported document layout depend on the viewer size
        viewer3.Height = 4000
        viewer3.Width = 2500
        viewer3.Dashboard.Title.Text = " Est. de Terceiros (" & Now.Date & ")"

        viewer3.Appearance.Font = New Font("Calibri", 2)
        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Calibri", 2)

        Dim MemRecibo3 As New MemoryStream()
        viewer3.ExportToPdf(MemRecibo3)


        'envio de email com o pdf
        ' Create a new memory stream and export the report into it as PDF.
        'oRelatorio.ExportToPdf(MemRecibo, optionsRecibo)

        ' Create a new attachment and put the PDF report into it.

        MemRecibo3.Seek(0, System.IO.SeekOrigin.Begin)

        Dim AttRecibo3 = New Attachment(MemRecibo3, "Estoque de terceiros.pdf", "application/pdf")

        Dim Mail As New MailMessage()
        Mail.Attachments.Add(AttRecibo3)

        ' Specify sender and recipient options for the e-mail message.
        Mail.From = New MailAddress("bi@aviacao.ind.br", "B.I Aviação")

        Mail.To.Add(New MailAddress("roberto@laticiniosaviacao.com.br"))
        Mail.To.Add(New MailAddress("compras@laticiniosaviacao.com.br"))

        Mail.Bcc.Add(New MailAddress("ssilveira1977@gmail.com"))
        Mail.Bcc.Add(New MailAddress("luizguilherme@4tsistemas.com.br"))


        ' 'email com copia oculta para matheus
        '  Mail.Bcc.Add(New MailAddress("matheus@laticiniosaviacao.com.br"))

        ' Specify other e-mail options.
        'Mail.Subject = "INDICADORES DE VENDA - " & CStr(Date.Now) & ""
        Mail.Subject = "PRODUTOS EM PODER DE TERCEIROS"
        Mail.Body = "E-mail automático enviado da plataforma 4TBI - NÃO RESPONDER ESSE E-MAIL"

        ' Send the e-mail message via the specified SMTP server.
        Dim Smtp = New SmtpClient("mail.aviacao.ind.br")
        Smtp.Port = 587
        Smtp.Credentials = New System.Net.NetworkCredential("bi@aviacao.ind.br", "200920")
        Smtp.EnableSsl = True

        Smtp.Send(Mail)

        ' Close the memory stream.

        MemRecibo3.Close()

        'Me.Close()
    End Sub


    Private Sub DashboardViewerEmail_DataLoading(sender As Object, e As DevExpress.DashboardCommon.DataLoadingEventArgs)
        If e.DataSourceName = "Object Data Source 1" Then
            e.Data = AspNet5t.dsProducaoPedido.GetProducaoPedido(False)
        End If
    End Sub


    Private Sub DashboardViewerEmail_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs)
        Dim parameters As SqlServerConnectionParametersBase = TryCast(e.ConnectionParameters, SqlServerConnectionParametersBase)
        If parameters IsNot Nothing Then
            parameters.ServerName = "SRVBI02\SQLSERVERSTD"
            parameters.DatabaseName = "s5taviacao"
            parameters.UserName = "4ts"
            parameters.Password = "Manager4ts"
        End If

    End Sub


    Private Sub DashboardViewerEmail_ConfigureDataConnectionOracle(sender As Object, e As ConfigureDataConnectionEventArgs)
        Dim parameters As OracleConnectionParameters = TryCast(e.ConnectionParameters, OracleConnectionParameters)
        If parameters IsNot Nothing Then
            parameters.ServerName = "192.168.50.36/PROTHEUSPROD"
            'parameters.DatabaseName = "matheus"
            parameters.UserName = "P11"
            parameters.Password = "P1112"
        End If

    End Sub


    Public Sub EnviaRelatorioVendasVendedor()

        
        'Dim dsDados = S5T.AviacaoVendasCollection.LoadViewRelVendedor(Date.Now, Date.Now)

        Try

            Dim VendedoresEmail = S5T.AviacaoVendedoresEmailCollection.LoadAllViewGrid

            For Each objVendedor In VendedoresEmail '.FindAll(Function(x) x.pCODIGO_VENDEDOR = "015")


                If Trim(objVendedor.pEMAIL_VENDEDOR) <> "" Then


                    ''Relatório Antigo, mudança a pedido do Matheus dia 16-01-2018
                    'Dim oRelatorio As New XtraReport1
                    'Dim dsVendas As List(Of S5T.AviacaoVendasRelVendedor) = dsDados
                    'dsVendas = dsVendas.FindAll(Function(x) Trim(x.pCODIGO_VENDEDOR) = Trim(objVendedor.pCODIGO_VENDEDOR))

                    'oRelatorio.DataSource = dsVendas
                    'oRelatorio.CreateDocument()

                    Dim oRelatorio = New repCnVendasVendasDiariaVendedorClienteLive

                    oRelatorio.Parameters(0).Value = objVendedor.pCODIGO_VENDEDOR
                    oRelatorio.Parameters(1).Value = date.now.Date
                    oRelatorio.Parameters(2).Value = date.now.Date
                    oRelatorio.CreateDocument()

                    Dim optionsRel As DevExpress.XtraPrinting.PdfExportOptions = New DevExpress.XtraPrinting.PdfExportOptions

                    If oRelatorio.RowCount > 0 Then

                        ' Create a new memory stream and export the report into it as PDF.
                        Dim MemRecibo As New MemoryStream()
                        oRelatorio.ExportToPdf(MemRecibo, optionsRel)

                        ' Create a new attachment and put the PDF report into it.
                        MemRecibo.Seek(0, System.IO.SeekOrigin.Begin)
                        Dim AttRecibo = New Attachment(MemRecibo, "Relatório de Vendas Diário - " & objVendedor.pCODIGO_VENDEDOR.ToString & ".pdf", "application/pdf")

                        ' Create a new message and attach the PDF report to it.
                        Dim Mail As New MailMessage()
                        Mail.Attachments.Add(AttRecibo)

                        ' Specify sender and recipient options for the e-mail message.
                        Mail.From = New MailAddress("bi@aviacao.ind.br", "B.I Aviação")

                        Mail.To.Add(New MailAddress(objVendedor.pEMAIL_VENDEDOR))
                        'Mail.Bcc.Add(New MailAddress("luizguilherme@4tsistemas.com.br"))
                        'Mail.Bcc.Add(New MailAddress("matheus@laticiniosaviacao.com.br"))
                        'Mail.Bcc.Add(New MailAddress("fani@laticiniosaviacao.com.br"))

                        ' Specify other e-mail options.
                        Mail.Subject = "Relatório de Vendas Diário -" & Date.Now.AddDays(-1) ' Ref. ao mês de " & MonthName(Date.Today.AddMonths(-1).Month) & yea
                        Mail.Body = "E-mail automático enviado da plataforma 4TBI - NÃO RESPONDER ESSE E-MAIL"


                        ' Send the e-mail message via the specified SMTP server.
                        ' Send the e-mail message via the specified SMTP server.
                        Dim Smtp = New SmtpClient("mail.aviacao.ind.br")
                        Smtp.Port = 587
                        Smtp.Credentials = New System.Net.NetworkCredential("bi@aviacao.ind.br", "200920")
                        Smtp.EnableSsl = True

                        Smtp.Send(Mail)

                        ' Close the memory stream.
                        MemRecibo.Close()

                    End If

                End If

            Next

        Catch ex As Exception
            MessageBox.Show(Me, "Erro no envio do relatório Vendas Vendedor.\n" + ex.ToString())
        End Try


        'Me.Close()
    End Sub

    
    Public Sub EnviaRelatorioOrdensErroProtheus()
        
        Try

       
            Dim oRelatorio = New RelOrdensErroProtheus

            oRelatorio.DataSource = S5T.LogFracionamentoCollection.LoadPeriodo(date.Today,date.Today)
            oRelatorio.Parameters(0).Value = date.Today + " a " + date.Today
            oRelatorio.CreateDocument()

            Dim optionsRel As DevExpress.XtraPrinting.PdfExportOptions = New DevExpress.XtraPrinting.PdfExportOptions

            If oRelatorio.RowCount > 0 Then

                ' Create a new memory stream and export the report into it as PDF.
                Dim MemRecibo As New MemoryStream()
                oRelatorio.ExportToPdf(MemRecibo, optionsRel)

                ' Create a new attachment and put the PDF report into it.
                MemRecibo.Seek(0, System.IO.SeekOrigin.Begin)
                Dim AttRecibo = New Attachment(MemRecibo, "Relatório de Ordens de Produção com Erro ao envio para o Protheus - " & DateTime.Now.Date & ".pdf", "application/pdf")

                ' Create a new message and attach the PDF report to it.
                Dim Mail As New MailMessage()
                Mail.Attachments.Add(AttRecibo)

                ' Specify sender and recipient options for the e-mail message.
                Mail.From = New MailAddress("bi@aviacao.ind.br", "B.I Aviação")

               
                Mail.Bcc.Add(New MailAddress("luizguilherme@4tsistemas.com.br"))
                Mail.Bcc.Add(New MailAddress("ssilveira1977@gmail.com"))

                Mail.To.Add(New MailAddress("matheus@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("everton@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("claudia@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("compras@laticiniosaviacao.com.br"))
                Mail.To.Add(New MailAddress("willian@aviacao.ind.br"))


                ' Specify other e-mail options.
                Mail.Subject = "Relatório de Ordens de Produção com Erro ao envio para o Protheus - " & DateTime.Now.Date 
                Mail.Body = "E-mail automático enviado da plataforma 4TBI - NÃO RESPONDER ESSE E-MAIL"

                ' Send the e-mail message via the specified SMTP server.
                ' Send the e-mail message via the specified SMTP server.
                Dim Smtp = New SmtpClient("mail.aviacao.ind.br")
                Smtp.Port = 587
                Smtp.Credentials = New System.Net.NetworkCredential("bi@aviacao.ind.br", "200920")
                Smtp.EnableSsl = True

                Smtp.Send(Mail)

                ' Close the memory stream.
                MemRecibo.Close()

            End If
            
        Catch ex As Exception
            MessageBox.Show(Me, "Erro no envio do relatório Fracionamento Ordens Erro Protheus.\n" + ex.ToString())
        End Try
        
    End Sub
    
    Public Sub EnviaRelatorioProducaoDiarioMVC()

        'Dim sConnectionString As String = "Data Source=GUILHERME-PC\SQLEXPRESS;Initial Catalog=s5tAviacaoMvc;User ID=4t;Password=Manager4ts"
        Dim sConnectionString As String = "Data Source=192.168.50.39;Initial Catalog=s5tAviacaoMvc;User ID=4ts;Password=Manager4ts"

        Dim objConn As New SqlConnection(sConnectionString)
        objConn.Open()

        Dim sSQL As String = "SELECT   "
        ssql = ssql + "         ProdutoCodigo "
        ssql = ssql + "         ,ProdutoDescricao "
        ssql = ssql + "         ,CONVERT(DATE, DataFabricacao) DataFabricacao "
        ssql = ssql + "                        ,CONVERT(DATE, DataValidade) DataValidade "
        ssql = ssql + "                                  ,Lote "
        ssql = ssql + "                                  ,SUM(Caixas) Caixas "
        ssql = ssql + "                                  ,SUM(Quantidade) Quantidade "
        ssql = ssql + "                                 FROM MovimentacaoDeEstoques "
        ssql = ssql + "                                 WHERE CONVERT(DATE, DataFabricacao) = '" & format(date.Today,"yyyy-MM-dd") & "' "
        ssql = ssql + "                                 GROUP BY ProdutoCodigo "
        ssql = ssql + "                                         ,ProdutoDescricao "
        ssql = ssql + "                                         ,Lote "
        ssql = ssql + "                                         ,CONVERT(DATE, DataFabricacao) "
        ssql = ssql + "                                         ,CONVERT(DATE, DataValidade) "

        Dim cmd As New SqlCommand(sSQL, objConn)

        Dim dr As SqlDataReader = cmd.ExecuteReader()

        dim dsDados as new List(Of S5T.lwMovimentacaoDeEstoqueEntradaPorProducao)

        While dr.Read()

            Dim obj as New S5T.lwMovimentacaoDeEstoqueEntradaPorProducao

            obj.ProdutoCodigo = dr("ProdutoCodigo").ToString()
            obj.ProdutoDescricao = dr("ProdutoDescricao").ToString()
            obj.DataFabricacao = CDate(dr("DataFabricacao").ToString())
            obj.DataValidade = cdate(dr("DataValidade").ToString())
            obj.Lote = dr("Lote").ToString()
            obj.Caixas = CInt(dr("Caixas").ToString())
            obj.Quantidade = CInt(dr("Quantidade").ToString())
            
            dsDados.Add(obj)
        End While

        dr.Close()

        objConn.Close()
      
       
        Dim oRelatorio = New repMovimentacaoDeEstoquesEntradaPorProducao

        oRelatorio.Parameters(0).Value = DateTime.Now.Date
        oRelatorio.DataSource = dsdados
        oRelatorio.CreateDocument()

        Dim optionsRel As DevExpress.XtraPrinting.PdfExportOptions = New DevExpress.XtraPrinting.PdfExportOptions

        If oRelatorio.RowCount > 0 Then

            ' Create a new memory stream and export the report into it as PDF.
            Dim MemRecibo As New MemoryStream()
            oRelatorio.ExportToPdf(MemRecibo, optionsRel)

            ' Create a new attachment and put the PDF report into it.
            MemRecibo.Seek(0, System.IO.SeekOrigin.Begin)
            Dim AttRecibo = New Attachment(MemRecibo, "Relatório de Movimentação De Estoque - Entrada por Produção Diário - " & DateTime.Now.Date & ".pdf", "application/pdf")

            ' Create a new message and attach the PDF report to it.
            Dim Mail As New MailMessage()
            Mail.Attachments.Add(AttRecibo)

            ' Specify sender and recipient options for the e-mail message.
            Mail.From = New MailAddress("bi@aviacao.ind.br", "B.I Aviação")

            Mail.Bcc.Add(New MailAddress("ssilveira1977@gmail.com"))
            Mail.Bcc.Add(New MailAddress("luizguilherme@4tsistemas.com.br"))

            Mail.To.Add(New MailAddress("marina@laticiniosaviacao.com.br"))
            Mail.To.Add(New MailAddress("claudia@laticiniosaviacao.com.br"))
            Mail.To.Add(New MailAddress("manteiga@aviacao.ind.br"))
            Mail.To.Add(New MailAddress("luizalberto@aviacao.ind.br"))
            Mail.To.Add(New MailAddress("willian@aviacao.ind.br"))


            ' Specify other e-mail options.
            Mail.Subject = "Relatório de Movimentação De Estoque - Entrada por Produção Diário - " & DateTime.Now.Date  ' Ref. ao mês de " & MonthName(Date.Today.AddMonths(-1).Month) & yea
            Mail.Body = "E-mail automático enviado da plataforma 4TBI - NÃO RESPONDER ESSE E-MAIL"


            ' Send the e-mail message via the specified SMTP server.
            ' Send the e-mail message via the specified SMTP server.
            Dim Smtp = New SmtpClient("mail.aviacao.ind.br")
            Smtp.Port = 587
            Smtp.Credentials = New System.Net.NetworkCredential("bi@aviacao.ind.br", "200920")
            Smtp.EnableSsl = True

            Smtp.Send(Mail)

            ' Close the memory stream.
            MemRecibo.Close()

        End If
        
    End Sub


End Class
