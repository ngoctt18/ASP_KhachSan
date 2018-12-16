<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title>Đặt dịch vụ</title>
      <!-- css files -->
      <link rel="stylesheet" href="assets/css/bootstrap.css">
      <!-- Bootstrap-Core-CSS -->
      <link rel="stylesheet" href="assets/css/style.css" type="text/css" media="all" />
      <!-- Style-CSS --> 
      <!-- //css files -->
      <!-- js -->
      <script type="text/javascript" src="assets/js/jquery-2.1.4.min.js"></script>
      <script type="text/javascript" src="assets/js/bootstrap.js"></script> <!-- Necessary-JavaScript-File-For-Bootstrap --> 
      <!-- //js -->
      <style type="text/css">
         img#imgSlide {
         position: absolute;
         max-width: 100%;
         height: 100%;
         }
         .footer-w3 {margin-top: 3px;}
         . {font-family: verdana;}
         h5 { font-family: verdana;}
		 .ddlAdd {
		    width: 80%;
			padding: 10px;
		 }
      </style>
   </head>
   <body>
      <form id="form1" runat="server">
         <!-- header -->
         <div class="header">
            <div class="agile-top-header">
               <div class="banner-agile-top">
                  <div class="number">
                     <h3><i class="fa fa-phone" aria-hidden="true"></i> +84 975 853 528</h3>
                  </div>
                  <div class="clearfix"></div>
               </div>
               <div class="logo">
                  <h1><a href="Order.aspx"><span>Đặt dịch vụ</span></a></h1>
               </div>
               <!-- navigation -->
               <div class="top-left">
                  <div class="top-nav">
                     <nav class="navbar navbar-default">
                        <!-- navbar-header -->
                        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                           <nav class="linkEffects linkHoverEffect_2">
                              <ul>
                                 <li><a href="index.aspx" data-link-alt="Home" class="scroll"><span>Trang chủ</span></a></li>
                                 <li><a href="Order.aspx" data-link-alt="Service" class="active"><span>Dịch vụ</span></a></li>
                                 <li><a href="news.aspx" data-link-alt="News" class="scroll"><span>Tin tức</span></a></li>
                                 <li><a href="Contact.aspx" data-link-alt="Contact" class="scroll"><span>Liên hệ</span></a></li>
                                 <li><a href="Admin/Dangnhap.aspx" data-link-alt="Admin" class="scroll"><span>Admin</span></a></li>
                              </ul>
                           </nav>
                        </div>
                     </nav>
                     <div class="clearfix"> </div>
                  </div>
               </div>
               <div class="clearfix"> </div>
               <!-- //navigation -->
            </div>
         </div>
         <!--Slider-->
         <div class="slider">
            <div class="callbacks_container">
               <ul class="rslides" id="slider">
                  <!--Slide random ASP-->
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                     <ContentTemplate>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:Timer ID="Timer2" runat="server" Interval="5000" OnTick="Timer2_Tick"></asp:Timer>
                        <asp:Image ID="imgSlide" runat="server" ImageUrl="assets/images/ban2.jpg" />
                     </ContentTemplate>
                  </asp:UpdatePanel>
                  <li>
                     <div class="slider-info">
                        <h3>Welcome!</h3>
                        <p style="color:#fff; font-size: 18px;">Khách sạn Welcome là khách sạn Quốc tế đầu tiên tại Hà Nội với 218 phòng nghỉ tiện nghi, hiện đại và sang trọng. Đặc biệt, với vị trí trung tâm thuận lợi kề bên Nhổn yên bình, khách sạn là điểm dừng chân lý tưởng của du khách trong và ngoài nước mỗi khi có chuyến công tác hay du lịch cùng bạn bè và người thân.</p>
                     </div>
                  </li>
               </ul>
            </div>
            <div class="clearfix"></div>
         </div>
         <!--//Slider-->
         <!--//main-->
         <div class="main" id="main" style="top: 22%;width: 35%;">
            <div class="w3layouts_main_grid">
               <div class="booking-form-head-agile">
                  <h3>Đặt dịch vụ tại phòng</h3>
               </div>
               <div class="agileits_main_grid w3_agileits_main_grid">
                  <div class="wthree_grid">
                     <h5>Chọn phòng </h5>
                     <asp:DropDownList class="ddlAdd" ID="drppickroom" required="" runat="server">
                     </asp:DropDownList>
                  </div>
               </div>
               <div class="agileits_main_grid w3_agileits_main_grid">
                  <div class="wthree_grid">
                     <h5>Chọn dịch vụ</h5>
                     <asp:DropDownList class="ddlAdd" ID="drppickservice" required="" runat="server">
                     </asp:DropDownList>
                  </div>
               </div>
               <div class="agileits_w3layouts_main_grid w3ls_main_grid">
                  <div class="agileinfo_grid">
                     <h5>Số lượng</h5>
                     <div class="agileits_w3layouts_main_gridl">
                        <asp:TextBox ID="txtpickquantity" runat="server" required="" />
                     </div>
                     <div class="clearfix"> </div>
                  </div>
               </div>
               <div class="w3_main_grid">
                  <asp:Label ID="err_msg" runat="server" />
                  <div class="w3_main_grid_right">
                     <asp:Button ID="btnOderUser" runat="server" Text="Đặt ngay" OnClientClick="return confirm('Chắc chắn đặt dịch vụ ?')" OnClick="btnOderUser_Click"/>
                  </div>
                  <div class="clearfix"> </div>
               </div>
            </div>
         </div>
         <!-- //header -->
		  
         <!-- /services -->
         <div class="services" id="services">
            <div class="container">
               <div class="services-agile-head">
                  <h3>Dịch vụ</h3>
               </div>
               <div class="w3-agile-grids">
                  <div class="col-md-6 w3-agile-services-left">
                     <div class="w3-services-text">
                        <ul class="services-head">
                           <li>
                              <h3>10</h3>
                           </li>
                           <li>
                              <h5>tuần</h5>
                           </li>
                           <li>
                              <h5>kinh nghiệm</h5>
                           </li>
                        </ul>
                        <p style="font-size: 15px;padding-right:15px;">Khách sạn Hà Nội là khách sạn Quốc tế đầu tiên tại Hà Nội với 218 phòng nghỉ tiện nghi, hiện đại và sang trọng. Đặc biệt, với vị trí trung tâm thuận lợi kề bên Hồ Giảng Võ yên bình, khách sạn là điểm dừng chân lý tưởng của du khách trong và ngoài nước mỗi khi có chuyến công tác hay du lịch cùng bạn bè và người thân..</p>
                        <p style="font-size: 15px;padding-right:15px;">Hơn nữa, Khách sạn Hà Nội đã được nổi danh là địa chỉ đứng đầu của Hà nội về ẩm thực Trung Hoa cùng các dịch vụ giải trí hoàn hảo và phong phú. Đến với Khách sạn Hà Nội, chúng tôi hy vọng sẽ đem lại cho quý khách những trải nghiệm thú vị và hài lòng nhất.</p>
                     </div>
                  </div>
                  <div class="col-md-6 w3-agile-services-right">
                     <img src="assets/images/ab1.jpg" alt="services">
                  </div>
                  <div class="clearfix"></div>
               </div>
            </div>
         </div>
         <!-- //services-->
         <!--footer-->
         <div class="footer-w3">
            <p>&copy; 2018 Website Hotel | ASP.NET</p>
         </div>
         <a href="#" id="toTop" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>
      </form>
   </body>
</html>