<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Harshama.aspx.cs" Inherits="Harshama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
<table align="center" border="1" cellpadding="10" cellspacing="10" style="direction:rtl;">

<tr>

<td> ת.ז </td>

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

<td style="color:red;background-color:aliceblue">סיסמא </td>

<td> <input type="password" name="pass1" /> </td>

</tr>

 

<tr>

<td>אימות סיסמא</td>

<td> <input type="password" name="pass2" /> </td>

</tr>

    <tr>
        <td> מין </td>
        <td><input type="radio" name:"male" />זכר </td>
        <td><input type="radio" name:"female" />נקבה</td>
    </tr>
<tr>


<td colspan="2"> <center><input type="submit" name="sub" value="שלח"/>

<input type="reset" value="נקה"/> </center>

</td>

</tr>

 

</table>

 </asp:Content>