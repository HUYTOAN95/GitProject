Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports DemoProject.DAL
Imports DemoProject.SO
Namespace DemoProject.SystemForm
	Public Partial Class FrmPassChange
		Inherits Form
		Protected Sub AlignCenterToScreen()
			Dim screen As Screen = Screen.FromControl(Me)
			Dim workingArea As Rectangle = screen.WorkingArea
			Me.Location = New Point() With { _
				Key .X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - Me.Width) / 2), _
				Key .Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - Me.Height) / 2) _
			}
		End Sub
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub btnHuyBo_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub
		Private Sub btnLuu_Click(sender As Object, e As EventArgs)
			Dim cnn As New SqlConnection(MyApp.MSSQLConnectionString)
			cnn.Open()
			If txtTenDN.Text = MyApp.gUserDB Then
				If txtMatKhauCu.Text = MyApp.gPwdDB Then
					If txtMatKhauMoi.Text = txtNhapLai.Text Then
						Dim newpass As String = txtMatKhauMoi.Text
						SqlConnection.ChangePassword(MyApp.MSSQLConnectionString, newpass)
						MyApp.gPwdDB = txtMatKhauMoi.Text
						MessageBox.Show("Đổi mật khẩu thành công! ")
					Else
						MessageBox.Show("Lỗi thay đổi mật khẩu!")
					End If
				Else
					MessageBox.Show("Mật khẩu cũ không đúng!")
				End If
			Else
				MessageBox.Show("Tên đăng nhập không đúng! ")
			End If
		End Sub
		Private Sub FrmPassChange_Load(sender As Object, e As EventArgs)
			AlignCenterToScreen()
			txtTenDN.Text = MyApp.gUserDB
		End Sub
		Private Sub txtNhapLai_TextChanged(sender As Object, e As EventArgs)
		End Sub
		Private Sub ckbcheckpass_CheckedChanged(sender As Object, e As EventArgs)
			If ckbcheckpass.Checked = True Then
				If txtNhapLai.Text = txtMatKhauMoi.Text Then
					MessageBox.Show("Mật khẩu trùng khớp ")
				Else
					MessageBox.Show("Maatk khẩu không trùng khớp ")
				End If
			End If
		End Sub
	End Class
End Namespace
