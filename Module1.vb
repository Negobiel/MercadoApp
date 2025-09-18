Module Module1
    Public db As New ADODB.Connection 'Variável do Banco
    Public rs As New ADODB.Recordset 'Variável da Tabela
    Public sql, diretorio, resp As String
    Public cont As Integer
    Public audio As Object
    Sub Conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAB5-08;Initial Catalog=mercado_app;trusted_connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "MERCADO LIVRE")

        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "MERCADO LIVRE")
        End Try
    End Sub

    '   Sub carregar_voz()
    '       audio = CreateObject("SAPI.SPVOICE")
    '       audio.volume = 100
    '       audio.rate = 1 'Velocidade de reprodução da fala

    '   End Sub

End Module
