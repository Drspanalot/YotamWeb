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

<td>טלפון </td>

<td> <input type="text" name="phone" /> </td>

</tr>

<tr>

<td>Email </td>

<td> <input type="text" name="email" /> </td>

</tr>

<tr>

<td>סיסמא </td>

<td> <input type="text" name="pass" /> </td>

</tr>

<tr>

<td> אימות סיסמא </td>

<td> <input type="text" name="pass2" /> </td>

</tr>

<tr>
    <td> מין </td>
    <td><input type="radio" name="gender" value="male" />זכר <input type="radio" name="gender" value="female" />נקבה</td>
</tr>
<tr>
    <td>מדינה </td>
    <td> <select name="country">
        <option value="choose"> בחר </option>
        <option value="usa"> ארצות הברית </option>
        <option value="uk"> אנגליה </option>
        <option value="isr"> ישראל </option>
        <option value="fr"> צרפת </option>
        <option value="other"> אחר </option>
         </select>
    </td>
</tr>
 

 

</table>

 </asp:Content>