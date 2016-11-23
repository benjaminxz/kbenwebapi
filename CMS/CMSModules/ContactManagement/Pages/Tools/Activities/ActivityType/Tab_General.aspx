<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Tab_General.aspx.cs"
    MasterPageFile="~/CMSMasterPages/UI/SimplePage.master" Title="Activity type properties - General"
    Inherits="CMSModules_ContactManagement_Pages_Tools_Activities_ActivityType_Tab_General" Theme="Default" %>            
    
<%@ Register Src="~/CMSModules/ContactManagement/Controls/UI/ActivityType/Edit.ascx" TagName="ActivityTypeEdit" TagPrefix="cms" %>
    
<asp:Content ID="cntBody" runat="server" ContentPlaceHolderID="plcContent">
    <cms:ActivityTypeEdit ID="editElem" runat="server" IsLiveSite="false" />
</asp:Content>