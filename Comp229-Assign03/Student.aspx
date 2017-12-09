<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Comp229_Assign03.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
    <br /><br /><br />

    <h1>Student Details</h1>

    <asp:GridView ID="ViewStudent" runat="server" AutoGenerateColumns="False"
        DataKeyNames="StudentID">
        <Columns>
            <asp:HyperLinkField DataTextField="StudentID" HeaderText="Student ID" Visible="true" DataNavigateUrlFields="StudentID"
                DataNavigateUrlFormatString="Update.aspx?StudentID={0}" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date (M/D/Y)" SortExpression="EnrollmentDate" />
            <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i>Delete"
                ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
        </Columns>
    </asp:GridView>

    <br />
    <br />

    <asp:GridView ID="CourseList" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="CourseID">
        <Columns>
            <asp:HyperLinkField DataTextField="Title" HeaderText="Course ID" Visible="true" DataNavigateUrlFields="CourseID"
                             DataNavigateUrlFormatString="Course.aspx?CourseID={0}" />
            <asp:BoundField DataField="Title" HeaderText="Title" Visible="true"/>
            <asp:BoundField DataField="Credits" HeaderText="Credits" Visible="true"/>
            <asp:BoundField DataField="DepartmentID" HeaderText="DepartmentID" Visible="true"/>
        </Columns>
    </asp:GridView>
            </center>

</asp:Content>
