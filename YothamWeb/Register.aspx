<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table border="1" cellpadding="10" cellspacing="10" style="direction:rtl;">

<tr>

<td> תעודת זהות </td>

<td> <input type="text" name="ident"/> </td>

</tr>

<tr>

<td>שם פרטי </td>

<td> <input type="text" name="fname" /> </td>

</tr>

<tr>

<td>שם משפחה </td>

<td> <input type="text" name="lname" /> </td>

</tr>

<tr>

<td style="color:red;background-color:aqua">סיסמא </td>

<td> <input type="password" name="pass1" /> </td>

</tr>

 

<tr>

<td>אימות סיסמא</td>

<td> <input type="password" name="pass2" /> </td>

</tr>

<tr>

<td colspan="2"> <center><input type="submit" name="subReg" value="בצע"/>

<input type="reset" value="נקה טופס"/> </center>

</td>

</tr>

 

<tr> 

<td> </td>

<td> </td>

</tr>

</table>

</asp:Content>

