﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Comp229_Assign03.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
    <br /><br /><br />


    <table>
             <tr>
                 <td class="WidthForColunms">StudentID:</td>
                 <td>
                 <asp:TextBox ID="StudentID" runat="server" ></asp:TextBox><br />
           
                 </td>
             </tr>
              <tr>
                 <td class="WidthForColunms">First Name:</td>
                 <td>
                 <asp:TextBox ID="Fname" runat="server" ></asp:TextBox><br />
           
                 </td>
             </tr>
     
             <tr>
                 <td class="WidthForColunms">Last Name:</td>
                 <td>
                 <asp:TextBox ID="Lname" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="WidthForColunms">Enrollment Date:</td>
                 <td>
                 <asp:TextBox ID="Date" TextMode="Date" runat="server" ></asp:TextBox> <!-- TODO: Pre-populate with today's date. --> 
                 </td>
             </tr>
             </table>

    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </center>

</asp:Content>
