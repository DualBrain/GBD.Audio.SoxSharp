Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class sox_effects_globals_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As sox_effects_globals_t) As HandleRef
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
                        libsoxPINVOKE.delete_sox_effects_globals_t(swigCPtr)
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


        Public Property plot() As sox_plot_t
            Set(ByVal value As sox_plot_t)
                libsoxPINVOKE.sox_effects_globals_t_plot_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As sox_plot_t = CType(libsoxPINVOKE.sox_effects_globals_t_plot_get(swigCPtr), sox_plot_t)
                Return ret
            End Get
        End Property

        Public Property global_info() As sox_globals_t
            Set(ByVal value As sox_globals_t)
                libsoxPINVOKE.sox_effects_globals_t_global_info_set(swigCPtr, sox_globals_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effects_globals_t_global_info_get(swigCPtr)
                Dim ret As sox_globals_t = If(cPtr = IntPtr.Zero, Nothing, New sox_globals_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_sox_effects_globals_t(), True)
        End Sub

    End Class

End Namespace