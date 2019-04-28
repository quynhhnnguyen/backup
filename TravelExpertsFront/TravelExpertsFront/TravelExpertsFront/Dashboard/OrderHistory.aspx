<%@ Page Title ="Order History" Language="C#" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="TravelExpertsFront.Dashboard.OrderHisory" MasterPageFile ="Dashoboard.Master" %>
<%-- 
    Order History Page - display customer's booking history 
            including product(s), package(s) break-down prices and total price.
    Login required to view this page
    Author: Quynh Nguyen (Queenie)
    Helper: Jeremiah Lobo
    Created Date: Jan 2019
--%>
 <asp:Content ID="contenthead" ContentPlaceHolderID="head" runat="server"></asp:Content>
     <asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="mainContent" runat="server">
        	<div class="content">
            	<div class="container">
                	<div class="row">
                        <% if (Convert.ToInt32(Session["BookingsCount"]) == 0) // No booking history
                            {%>
                            <div class="card">
	                            <div class="card-header">
	                                <h4 class="card-title">Sorry!</h4>
	                            </div>
	                            <div class="card-content">
                                    <h1>We didn't find any Orders</h1>
                                </div>
	                        </div>
                        <%} %>
                        <%-- Building Booking list --%>
                        <asp:DataList ID="dlBookings" runat="server"  OnItemDataBound="dlBookings_ItemDataBound">
                            <ItemTemplate>
                            <div class="col-lg-6 col-md-6 col-sm-6">
							<div class="card card-circle-chart grow" data-background-color="orange">
                              <%--  data-color="blue | azure | green | orange | red | purple"--%>
								<div class="card-header">
                                    <asp:TextBox ID="BookingId" Text='<%# Eval("BookingId") %>' runat="server" Visible="false"/>
	                                <h4 class="card-title text-left">Booking Number: <asp:Label ID="BookingNoLabel" runat="server" Text='<%# Eval("BookingNo") %>' /></h4>
                                    <h6 class="card-subtitle text-left"><em> <asp:Label ID="lblPackageName" runat="server" Text='<%# Eval("PackageName") %>' /></em></h6>
	                                <p class="description text-left"><span class="ti-briefcase""></span> <asp:Label ID="TTNameLabel" runat="server" Text='<%# Eval("TTName") +"Class" %>' />
                                    <p class="description text-left"> <span class="ti-location-pin "></span><asp:Label ID="lblDestination" runat="server" Text='<%# Eval("Destination") %>' /></p>
                                    <p class="description text-left"> <span class="ti-user"></span><span class="ti-user"></span> <asp:Label ID="lblTotalCustomers" runat="server" Text='<%# Eval("TravelerCount") %>' /></p>
                                    <p class="description text-left"><span class="ti-ticket"></span><asp:Label ID="lblTotalCost" runat="server" Text='<%# string.Format("{0:$#,###.##}", Eval("TotalCost")) %>' /></p>
                                    <p> More Information </p>
	                            </div>
                                
							    <div class="card-content">
                                    <%-- Building Booking Details --%>
                                    <asp:ListView ID="dlBookingDetails"  runat="server">
                                         <ItemTemplate>
                                            <table class="table table-no-bordered" >
	                                            <tbody>
	                                                <tr>
                                                        
	                                        	        <td class="text-right"><br><span class="ti-direction-alt"></span><asp:Label ID="Label4" runat="server" Text='<%#Eval("Description").ToString().Replace("/", "-")%>' /></td>
	                                        	
                                                        <td class="text-left">From <br><asp:Label ID="TripStartLabel" runat="server" Text='<%# string.Format("{0:MM/dd/yyyy}", Eval("TripStart")) %>'/></td>
                                                        <td class="text-left">To <br><asp:Label ID="TripEndLabel" runat="server" Text='<%# string.Format("{0:MM/dd/yyyy}", Eval("TripEnd")) %>'/></td>
                                                        <td></td>
	                                                </tr>
                                                    <tr>
	                                        	        <td class="text-right"><span class="ti-car"></span>  Travelling via</td>
	                                        	        <td class="text-center"><asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' /></td>
                                                        <td class="text-left"> by <asp:Label ID="SupNameLabel" runat="server" Text='<%# Eval("SupName") %>' /></td>
                                                        <td></td>
	                                                </tr>
                                           
	                                                <tr>
	                                        	
	                                        	        <td></td>
	                                        	        <td class="text-left">Package Base Price </td>
	                                        	        <td class="text-left"><asp:Label ID="lblBasePrice" runat="server" Text='<%# string.Format("{0:$#,###.##}", Eval("BasePrice")) %>'/></td>
	                                        	        <td></td>
	                                                </tr>
	                                                <tr>	                                        	
	                                        	        <td></td>
	                                        	        <td class="text-left">Agency Commission:</td>
	                                        	        <td class="text-left"><asp:Label ID="lblAgencyCommission" runat="server" Text='<%# string.Format("{0:$#,###.##}", Eval("AgencyCommission")) %>'/></td>
	                                        	        <td></td>
	                                                </tr>                                           
	                                        
	                                            </tbody>
	                                        </table>
                                        </ItemTemplate>                                             
                                     </asp:ListView>
                                 </div>
                                 <div class="card-content">
                                     <table class="table table-no-bordered" >
	                                            <tbody>
	                                                <tr>         
	                                        	
                                                        <td></td>
                                                        <td></td>
                                                        <td class="text-right">Total: </td>
                                                        <td class="text-left"><asp:Label ID="lblTotalCost1" runat="server" Text='<%# string.Format("{0:$#,###.##}", Eval("TotalCost")) %>' /></td>
                                                        
	                                                </tr>
                                                </tbody>
                                            </table>
                            </ItemTemplate>

                            
                        </asp:DataList>
                    
                	</div>
                </div>
            </div>
         </asp:Content>



