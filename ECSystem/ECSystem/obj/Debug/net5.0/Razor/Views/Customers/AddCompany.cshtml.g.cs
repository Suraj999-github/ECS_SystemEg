<<<<<<< HEAD
#pragma checksum "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26eec59b86d5adcd0ddf3fbe14631535af240806"
=======
#pragma checksum "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26eec59b86d5adcd0ddf3fbe14631535af240806"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_AddCompany), @"mvc.1.0.view", @"/Views/Customers/AddCompany.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
<<<<<<< HEAD
#line 1 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\_ViewImports.cshtml"
=======
#line 1 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\_ViewImports.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
using ECSystem;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\_ViewImports.cshtml"
=======
#line 2 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\_ViewImports.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
using ECSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26eec59b86d5adcd0ddf3fbe14631535af240806", @"/Views/Customers/AddCompany.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b908c5e31e93c17706dc468abf700176846cfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_AddCompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECSystem.Models.InsertCompanyCustomerModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 2 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 2 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
  
    ViewBag.Title = "Add Company";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h6>Customer / Corporate Customer</h6>\r\n        </div>\r\n        <div class=\"card-body\">\r\n");
#nullable restore
<<<<<<< HEAD
#line 13 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 13 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
             using (Html.BeginForm("AddCompany", "Customers", FormMethod.Post, new { @class = "form-horizontal", @role = "form", @id = "AddCompany" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 15 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 15 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-6\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"control-label\"> ");
#nullable restore
<<<<<<< HEAD
#line 19 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 19 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                 Write(Html.LabelFor(m => m.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"text-danger\">*</small></label>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 20 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 20 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                   Write(Html.TextBoxFor(model => model.CompanyName, Model.CompanyName, new { @class = "form-control", @required = "required", @placeholder = "Enter Company Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 21 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 21 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                   Write(Html.ValidationMessageFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    </div>\r\n                <div class=\"col-6\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"control-label\"> ");
#nullable restore
<<<<<<< HEAD
#line 26 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 26 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                 Write(Html.LabelFor(m => m.CompanyAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"text-danger\">*</small></label>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 27 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 27 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                   Write(Html.TextBoxFor(model => model.CompanyAddress, Model.CompanyAddress, new { @class = "form-control", @required = "required", @placeholder = "Enter Company Address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 28 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 28 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                   Write(Html.ValidationMessageFor(model => model.CompanyAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                    <div class=\"col-6\">\r\n                        <div class=\"form-group\">\r\n                            <label class=\"control-label\"> ");
#nullable restore
<<<<<<< HEAD
#line 33 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 33 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                     Write(Html.LabelFor(m => m.CompanyPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"text-danger\">*</small></label>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 34 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 34 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                       Write(Html.TextBoxFor(model => model.CompanyPhone, Model.CompanyPhone, new { @class = "form-control", @required = "required", @placeholder = "Enter Company Phone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 35 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 35 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                       Write(Html.ValidationMessageFor(model => model.CompanyPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                        <div class=\"col-6\">\r\n                            <div class=\"form-group\">\r\n                                <label class=\"control-label\"> ");
#nullable restore
<<<<<<< HEAD
#line 40 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 40 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                         Write(Html.LabelFor(m => m.CompanyFax));

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"text-danger\">*</small></label>\r\n                                ");
#nullable restore
<<<<<<< HEAD
#line 41 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 41 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                           Write(Html.TextBoxFor(model => model.CompanyFax, Model.CompanyFax, new { @class = "form-control", @required = "required", @placeholder = "Enter Company Fax" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
<<<<<<< HEAD
#line 42 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 42 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                           Write(Html.ValidationMessageFor(model => model.CompanyFax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                            <div class=\"col-6\">\r\n                                <div class=\"form-group\">\r\n                                    <label class=\"control-label\"> ");
#nullable restore
<<<<<<< HEAD
#line 47 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 47 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                             Write(Html.LabelFor(m => m.ShippingMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"text-danger\">*</small></label>\r\n                                    ");
#nullable restore
<<<<<<< HEAD
#line 48 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 48 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                               Write(Html.TextBoxFor(model => model.ShippingMethod, Model.ShippingMethod, new { @class = "form-control", @required = "required", @placeholder = "Enter Shipping Method" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
<<<<<<< HEAD
#line 49 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 49 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                               Write(Html.ValidationMessageFor(model => model.ShippingMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                                <div class=""col-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label""> ");
#nullable restore
<<<<<<< HEAD
#line 54 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 54 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                                 Write(Html.LabelFor(m => m.BuyerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        ");
#nullable restore
<<<<<<< HEAD
#line 55 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 55 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                   Write(Html.TextBoxFor(model => model.BuyerName, Model.BuyerName, new { @class = "form-control", @placeholder = "Enter Buyer Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
<<<<<<< HEAD
#line 56 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 56 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                   Write(Html.ValidationMessageFor(model => model.BuyerName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                    <div class=""col-6"">
                                        <div class=""form-group"">
                                            <label class=""control-label""> ");
#nullable restore
<<<<<<< HEAD
#line 61 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 61 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                                     Write(Html.LabelFor(m => m.BuyerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            ");
#nullable restore
<<<<<<< HEAD
#line 62 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 62 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                       Write(Html.TextBoxFor(model => model.BuyerPhone, Model.BuyerPhone, new { @class = "form-control", @placeholder = "Enter Buyer Phone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
<<<<<<< HEAD
#line 63 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 63 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                       Write(Html.ValidationMessageFor(model => model.BuyerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                        <div class=""col-6"">
                                            <div class=""form-group"">
                                                <label class=""control-label""> ");
#nullable restore
<<<<<<< HEAD
#line 68 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 68 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                                                         Write(Html.LabelFor(m => m.BuyerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                ");
#nullable restore
<<<<<<< HEAD
#line 69 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 69 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                           Write(Html.TextBoxFor(model => model.BuyerEmail, Model.BuyerEmail, new { @class = "form-control", @placeholder = "Enter Buyer Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                ");
#nullable restore
<<<<<<< HEAD
#line 70 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 70 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
                                           Write(Html.ValidationMessageFor(model => model.BuyerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        </div>\r\n                <button type=\"submit\" class=\"btn btn-primary mt-3\">Submit</button>\r\n");
#nullable restore
<<<<<<< HEAD
#line 75 "D:\Task Project Suraj Goud\My_ECS_System\ECS_SystemEg\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
=======
#line 75 "D:\Task Project Suraj Goud\ECSystem\ECSystem\Views\Customers\AddCompany.cshtml"
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>           \r\n    </div>   \r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECSystem.Models.InsertCompanyCustomerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
