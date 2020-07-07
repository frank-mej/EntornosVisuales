﻿Imports System.Data.SqlClient

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-8VGV6BL;Initial Catalog=Tienda; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consulta() As DataTable
        Try

            conexion.Open()

            Dim cmd As New SqlCommand("consultaTienda", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarT As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarT, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarT As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarT, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function buscarCliente(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.cliente " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function validarTienda(ByVal codigo As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.cliente where codigo='" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function

    Function insertarT(ByVal codigo As String, ByVal Nombre As String, ByVal primerApellido As String, ByVal segundoApellido As String, ByVal producto As String, ByVal cantidad As Integer, ByVal precio As Integer, ByVal fecha As String) As String
        Dim mensaje As String = "Cliente Almacenado"
        Try
            comando = New SqlCommand("Insert into personas.estudiante(codigo,nombre,primerApellido,segundoApellido,prodcuto,cantidad,precio, fecha) values ('" & codigo & "','" & Nombre & "','" & primerApellido & "','" + segundoApellido + "','" & producto & "','" & cantidad & "','" & precio & "','" & fecha & "')", conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = "No se inserto por: " + ex.ToString
        End Try
        Return mensaje
    End Function

End Class
