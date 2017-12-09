<%@ Page Title="Home Page" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Comp229_Assign03._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <center>
        <br /><br /><br />
    <h1>Student list of University</h1>

    <asp:GridView ID="StudentsGridView" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="StudentID" AllowSorting="True">
        <Columns>
            <asp:HyperLinkField DataTextField="StudentID" HeaderText="Student ID" Visible="true" DataNavigateUrlFields="StudentID"
                DataNavigateUrlFormatString="Student.aspx?StudentID={0}" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date (M/D/Y)" />
        </Columns>
    </asp:GridView>
        <br />
    <br />
    <a id="AddStudent" style="border:solid;border-radius:4px;background-color:lightblue;color:white;padding:15px;border-color:black;font-size:15px" href="AddStudent.aspx">Add New Student</a>
    </center>

</asp:Content>
