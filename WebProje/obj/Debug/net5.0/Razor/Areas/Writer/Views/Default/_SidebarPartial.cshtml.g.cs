#pragma checksum "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Areas\Writer\Views\Default\_SidebarPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "788ca59f032cf6c562f9e112085ce49b2188ae225d9b1e8b2aeafb8b075ce2e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default__SidebarPartial), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"788ca59f032cf6c562f9e112085ce49b2188ae225d9b1e8b2aeafb8b075ce2e4", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default__SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
	<ul class=""nav"">
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
				<i class=""icon-grid menu-icon""></i>
				<span class=""menu-title"">Dashboard</span>
			</a>
		</li>
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Message/RecieverMessage"">
				<i class=""icon-mail menu-icon""></i>
				<span class=""menu-title"">Gelen Mesajlar</span>
		
			</a>

		</li>
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Message/SenderMessage"">
				<i class=""icon-mail menu-icon""></i>
				<span class=""menu-title"">Giden Mesajlar</span>

			</a>

		</li>
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Message/SendMessage"">
				<i class=""icon-mail menu-icon""></i>
				<span class=""menu-title"">Yeni Mesaj</span>

			</a>

		</li>
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Default/Index/"">
				<i class=""ti-announcement menu-icon""></i>
				<span class=""menu-title"">Duy");
            WriteLiteral(@"urular</span>

			</a>

		</li>
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Profile/Index/"">
				<i class=""ti-microphone menu-icon""></i>
				<span class=""menu-title"">Profil</span>
				
			</a>
		</li>


		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Profile/Index/"">
				<i class=""ti-settings menu-icon""></i>
				<span class=""menu-title"">Ayarlar</span>
			</a>
		</li>
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Dashboard/Index/"">
				<i class=""ti-user menu-icon""></i>
				<span class=""menu-title"">Admin Sayfası</span>
			</a>
		</li>
		<li class=""nav-item"">
			<a class=""nav-link"" href=""/Writer/Login/LogOut"">
				<i class=""ti-power-off menu-icon""></i>
				<span class=""menu-title"">Çıkış Yap</span>
			</a>
		</li>
	</ul>
</nav>
<script>
	document.querySelectorAll('.nav-link').forEach(link => {
		if (link.href === window.location.href) {
			link.classList.add('active');
		}
	});</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
