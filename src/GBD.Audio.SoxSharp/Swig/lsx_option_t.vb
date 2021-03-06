Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class lsx_option_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As lsx_option_t) As HandleRef
            Return If(obj Is Nothing, New HandleRef(Nothing, IntPtr.Zero), obj.swigCPtr)
        End Function

        Protected Overrides Sub Finalize()
            Dispose()
        End Sub

        Public Overridable Sub Dispose() Implements IDisposable.Dispose
            SyncLock Me
                If swigCPtr.Handle <> IntPtr.Zero Then
                    If swigCMemOwn Then
                        swigCMemOwn = False
                        libsoxPINVOKE.delete_lsx_option_t(swigCPtr)
                    End If
                    swigCPtr = New HandleRef(Nothing, IntPtr.Zero)
                End If
                GC.SuppressFinalize(Me)
            End SyncLock
        End Sub

        Public Sub New(ByVal cPtr As IntPtr)
            swigCMemOwn = False
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Public Function GetswigCPtr() As IntPtr
            Return swigCPtr.Handle
        End Function


        Public Property name() As String
            Set(ByVal value As String)
                libsoxPINVOKE.lsx_option_t_name_set(swigCPtr, value)
            End Set
            Get
                Dim ret As String = libsoxPINVOKE.lsx_option_t_name_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property has_arg() As lsx_option_arg_t
            Set(ByVal value As lsx_option_arg_t)
                libsoxPINVOKE.lsx_option_t_has_arg_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As lsx_option_arg_t = CType(libsoxPINVOKE.lsx_option_t_has_arg_get(swigCPtr), lsx_option_arg_t)
                Return ret
            End Get
        End Property

        Public Property flag() As SWIGTYPE_p_int
            Set(ByVal value As SWIGTYPE_p_int)
                libsoxPINVOKE.lsx_option_t_flag_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.lsx_option_t_flag_get(swigCPtr)
                Dim ret As SWIGTYPE_p_int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property val() As Integer
            Set(ByVal value As Integer)
                libsoxPINVOKE.lsx_option_t_val_set(swigCPtr, value)
            End Set
            Get
                Dim ret As Integer = libsoxPINVOKE.lsx_option_t_val_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_lsx_option_t(), True)
        End Sub

    End Class

End Namespace
