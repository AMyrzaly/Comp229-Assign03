<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Addtocourse.aspx.cs" Inherits="Comp229_Assign03.Addtocourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
    <br /><br /><br />

    <h1>You can enroll student to the course!</h1>
        <h2>You have to...</h2>
            Enter the Existance studentID
            Enter the Existance CourseID
        <hr />
        <table>
            <tr>
                <td class="WidthForColunms">StudentID:</td>
                <td>
                    <asp:TextBox ID="txtBxStudentID" runat="server"></asp:TextBox><br />

                </td>
            </tr>

            <tr>
                <td class="WidthForColunms">CourseID:</td>
                <td>
                    <asp:TextBox ID="txtBxCourseID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="WidthForColunms">Grade:</td>
                <td>
                    <asp:TextBox ID="txtBxGrade" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" CssClass="PageBtns" />
        <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CssClass="PageBtns" />

        <br />
        <br />

            </center>

</asp:Content>
