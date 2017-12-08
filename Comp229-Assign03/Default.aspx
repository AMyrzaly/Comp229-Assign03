<%@ Page Title="Home Page" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Comp229_Assign03._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Student list</h1>

    <asp:GridView ID="StudentsGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentID" DataSourceID="datSourSelAllStu" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:HyperLinkField DataTextField="StudentID" HeaderText="Student ID" Visible="true" DataNavigateUrlFields="StudentID"
                DataNavigateUrlFormatString="Student.aspx?StudentID={0}" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" SortExpression="FirstMidName" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date (M/D/Y)" SortExpression="EnrollmentDate" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="datSourSelAllStu" runat="server" ConnectionString="<%$ ConnectionStrings:Assginment_03 %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>

    <br />
    <a id="AddStudent" href="AddStudent.aspx">Add New Student</a>

</asp:Content>
