Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class sox_effects_chain_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As sox_effects_chain_t) As HandleRef
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
                        libsoxPINVOKE.delete_sox_effects_chain_t(swigCPtr)
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


        Public Property effects() As SWIGTYPE_p_p_sox_effect_t
            Set(ByVal value As SWIGTYPE_p_p_sox_effect_t)
                libsoxPINVOKE.sox_effects_chain_t_effects_set(swigCPtr, SWIGTYPE_p_p_sox_effect_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effects_chain_t_effects_get(swigCPtr)
                Dim ret As SWIGTYPE_p_p_sox_effect_t = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_p_sox_effect_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property table_size() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effects_chain_t_table_size_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effects_chain_t_table_size_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property length() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effects_chain_t_length_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effects_chain_t_length_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property ibufc() As SWIGTYPE_p_p_int
            Set(ByVal value As SWIGTYPE_p_p_int)
                libsoxPINVOKE.sox_effects_chain_t_ibufc_set(swigCPtr, SWIGTYPE_p_p_int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effects_chain_t_ibufc_get(swigCPtr)
                Dim ret As SWIGTYPE_p_p_int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_p_int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property obufc() As SWIGTYPE_p_p_int
            Set(ByVal value As SWIGTYPE_p_p_int)
                libsoxPINVOKE.sox_effects_chain_t_obufc_set(swigCPtr, SWIGTYPE_p_p_int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effects_chain_t_obufc_get(swigCPtr)
                Dim ret As SWIGTYPE_p_p_int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_p_int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property global_info() As sox_effects_globals_t
            Set(ByVal value As sox_effects_globals_t)
                libsoxPINVOKE.sox_effects_chain_t_global_info_set(swigCPtr, sox_effects_globals_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effects_chain_t_global_info_get(swigCPtr)
                Dim ret As sox_effects_globals_t = If(cPtr = IntPtr.Zero, Nothing, New sox_effects_globals_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property in_enc() As sox_encodinginfo_t
            Set(ByVal value As sox_encodinginfo_t)
                libsoxPINVOKE.sox_effects_chain_t_in_enc_set(swigCPtr, sox_encodinginfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effects_chain_t_in_enc_get(swigCPtr)
                Dim ret As sox_encodinginfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_encodinginfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property out_enc() As sox_encodinginfo_t
            Set(ByVal value As sox_encodinginfo_t)
                libsoxPINVOKE.sox_effects_chain_t_out_enc_set(swigCPtr, sox_encodinginfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effects_chain_t_out_enc_get(swigCPtr)
                Dim ret As sox_encodinginfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_encodinginfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_sox_effects_chain_t(), True)
        End Sub

    End Class

End Namespace
