﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="FwjSoft.Web.MenuInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		菜单ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		菜单名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		命名空间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuSpaceName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		窗体名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuFrmName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		上级菜单ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuParentId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		菜单是否启用
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuUse" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




