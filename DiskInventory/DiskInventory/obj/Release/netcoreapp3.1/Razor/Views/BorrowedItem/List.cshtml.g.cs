#pragma checksum "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c0f5e1792b967fc4fef209a9732aeed6639d1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BorrowedItem_List), @"mvc.1.0.view", @"/Views/BorrowedItem/List.cshtml")]
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
#line 1 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\_ViewImports.cshtml"
using DiskInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\_ViewImports.cshtml"
using DiskInventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c0f5e1792b967fc4fef209a9732aeed6639d1f", @"/Views/BorrowedItem/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fcf1ec9a08e63548f6b2cf1328f6c42701ad4d", @"/Views/_ViewImports.cshtml")]
    public class Views_BorrowedItem_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DiskInventory.Models.BorrowedItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BorrowedItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
  
    ViewBag.Title = "Borrowed Item Manager";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2>List of people of whom I have lent out items.</h2>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c0f5e1792b967fc4fef209a9732aeed6639d1f4719", async() => {
                WriteLiteral("Check out an item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
 if (Model.Count() > 0)

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
                                                                                
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table_bordered table-striped"">
        <thead>
            <tr>
                <th>Item Name</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Borrowed Date</th>
                <th>Returned Date</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
             foreach (var borroweditem in Model)

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
                                                                                               
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
               Write(borroweditem.Item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
               Write(borroweditem.Borrower.BorrowerFname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
               Write(borroweditem.Borrower.BorrowerLname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
               Write(borroweditem.BorrowDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
               Write(borroweditem.ReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c0f5e1792b967fc4fef209a9732aeed6639d1f9134", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
                                                                         WriteLiteral(borroweditem.BorrowedItemID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                    \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 41 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>No data found.</div>\r\n");
#nullable restore
#line 45 "C:\Users\dbryant\Documents\GitHub\SWDV235_Project\DiskInventory\DiskInventory\Views\BorrowedItem\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DiskInventory.Models.BorrowedItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591