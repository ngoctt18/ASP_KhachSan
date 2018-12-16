<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title>ASP | Website khách sạn</title>
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
         .portfolio-grids img {
            max-width: 70%;
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
                                 <li><a href="Order.aspx" data-link-alt="Service" class="scroll"><span>Dịch vụ</span></a></li>
                                 <li><a href="news.aspx" data-link-alt="News" class="active"><span>Tin tức</span></a></li>
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
         </div>
         <!-- //header -->
         <!-- Gallery -->
         <div id="gallery" class="gallery">
            <div class="container">
               <div class="agileits-gal-title">
                  <h3>Our news</h3>
               </div>
               <div class="sap_tabs">
                  <div id="horizontalTab">
                     <div class="clearfix"> </div>
                     <div class="resp-tabs-container">
                         <%
                             var news = new DataUtil().getAllNews();
                             foreach(var tin in news)
                             {
                                 Response.Write("<div class='tab-1'>");
                                 Response.Write("<div class='clearfix'></div>");
                                 Response.Write("<div class='col-md-6 portfolio-grids offer-gal-images offer-gal-img2'>");
                                 Response.Write("<img src='Admin/images/"+tin.news_avatar+"' />");
                                 Response.Write("</div>");
                                 Response.Write("<div class='col-md-6 portfolio-grids'>");
                                 Response.Write("<div class='gallery-text-agile agile-offer1'>");
                                 Response.Write("<h3>"+tin.news_title+"</h3>");
                                 Response.Write("<p>"+tin.news_description+"</p>");
                                 Response.Write("<p>"+tin.news_content+"</p>");
                                 Response.Write("</div>");
                                 Response.Write(" </div>");
                                 Response.Write(" <div class='clearfix'></div>");
                                 Response.Write(" </div>");
                             }
                             %>
                         
                     </div>
                  </div>
               </div>
            </div>
         </div>
         <!-- //Gallery -->
         <!--footer-->
         <div class="footer-w3">
            <p>&copy; 2018 Website Hotel | ASP.NET</p>
         </div>
         <a href="#" id="toTop" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>
      </form>
   </body>
</html>