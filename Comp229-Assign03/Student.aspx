<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Comp229_Assign03.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Student Details</h1>

    <asp:GridView ID="ViewStudent" runat="server" AutoGenerateColumns="False"
        DataKeyNames="StudentID">
        <Columns>
            <asp:HyperLinkField DataTextField="StudentID" HeaderText="Student Id" Visible="true" DataNavigateUrlFields="StudentID"
                DataNavigateUrlFormatString="Update.aspx?StudentID={0}" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date (M/D/Y)" SortExpression="EnrollmentDate" />
            <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i>Delete"
                ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
        </Columns>
    </asp:GridView>

    <asp:GridView ID="CourseList" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="CourseID">
        <Columns>
            <asp:BoundField DataField="CourseID" HeaderText="CourseID" InsertVisible="False" ReadOnly="True" SortExpression="CourseID" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Credits" HeaderText="Credits" SortExpression="Credits" />
            <asp:BoundField DataField="DepartmentID" HeaderText="DepartmentID" SortExpression="DepartmentID" />
        </Columns>
    </asp:GridView>

</asp:Content>
