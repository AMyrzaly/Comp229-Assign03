<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="Comp229_Assign03.Course" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
    <br /><br /><br />

    <asp:GridView ID="CourseList" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="StudentID" >
        <Columns>
            <asp:BoundField DataField="StudentID" HeaderText="StudentID" InsertVisible="False" ReadOnly="True" SortExpression="StudentID" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" />
            <asp:BoundField DataField="FirstMidName" HeaderText="FirstMidName" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="EnrollmentDate" />
        
            <asp:CommandField HeaderText="Delete" DeleteText="Delete" 
                ShowDeleteButton="true" ButtonType="Link" />
        
        </Columns>
    </asp:GridView>
        <br />
        <br />
    <a style="border:solid;border-radius:4px;background-color:lightblue;color:white;padding:15px;border-color:black;font-size:15px" href="Update.aspx">Update Page</a>
    <a id="PageBtnsForCourseAdd" style="border:solid;border-radius:4px;background-color:lightblue;color:white;padding:15px;border-color:black;font-size:15px" href="Addtocourse.aspx"><i class="fa fa-plus"></i>Add Student to Course</a>
    </center>

</asp:Content>
