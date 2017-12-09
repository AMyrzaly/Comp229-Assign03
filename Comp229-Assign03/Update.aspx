﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Comp229_Assign03.Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Update pages</h1>
    <div id="addStudent">
        <table>
            <tr>
                <td class="WidthForColunms">First Name:</td>
                <td>
                    <asp:TextBox ID="txtBxFname" runat="server"></asp:TextBox><br />
                </td>
            </tr>

            <tr>
                <td class="WidthForColunms">Last Name:</td>
                <td>
                    <asp:TextBox ID="txtBxLname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="WidthForColunms">Enrollment Date:</td>
                <td>
                    <asp:TextBox ID="txtBxEnrDate" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>

        <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CssClass="btn btn-primary btn-lg" />
        <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click" CssClass="btn btn-primary btn-lg" />
        <br />
        <br />
    </div>

</asp:Content>