<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Comp229_Assign03.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Student Details</h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:HyperLinkField DataTextField="StudentID" HeaderText="Student Id" Visible="true" DataNavigateUrlFields="StudentID"
                             DataNavigateUrlFormatString="update.aspx?StudentID={0}" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" Visible="true" />
            <asp:BoundField DataField="FirstMidName" HeaderText="FirstMidName" Visible="true" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="EnrollmentDate" Visible="true" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Assginment_03 %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>

</asp:Content>
