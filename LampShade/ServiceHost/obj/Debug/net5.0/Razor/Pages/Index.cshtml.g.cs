#pragma checksum "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77105dd039b30416e21972a8b15cc888c3111905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ServiceHost.Pages
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
#line 1 "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77105dd039b30416e21972a8b15cc888c3111905", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/img/icons/free_shipping.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/img/icons/money_back.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/img/icons/support247.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\Index.cshtml"
  
    ViewData["Title"] = "صفحه اصلی فروشگاه";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Slide"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategoryWithProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArrivals"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

<!--<div class=""banner-hover-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">-->
                <!--=======  banner hover wrapper  =======-->
                <!--<div class=""banner-hover-wrapper"">
                    <div class=""row"">
                        <div class=""col-md-6"">-->
                            <!--=======  single hover banner  =======-->
                            <!--<div class=""single-hover-banner"">
                                <div class=""single-hover-banner__image"">
                                    <a href=""shop-left-sidebar.html"">
                                        <img src=""~/Theme/assets/img/banners/img1-middle-eposi1.jpg"" class=""img-fluid""
                                             alt="""">
                                    </a>
                                    <div class=""single-hover-banner__content"">
                                        <h4 class=""small-text"">Black Friday</h4>");
            WriteLiteral(@"
                                        <h3 class=""big-text"">Save Up To 50% Off</h3>
                                        <a class=""banner-link"" href=""shop-left-sidebar.html"">SHOP NOW</a>
                                    </div>
                                </div>
                            </div>-->
                            <!--=======  End of single hover banner  =======-->
                        <!--</div>

                        <div class=""col-md-6"">-->
                            <!--=======  single hover banner  =======-->
                            <!--<div class=""single-hover-banner"">
                                <div class=""single-hover-banner__image"">
                                    <a href=""shop-left-sidebar.html"">
                                        <img src=""~/Theme/assets/img/banners/img2-middle-eposi1.jpg"" class=""img-fluid""
                                             alt="""">
                                    </a>
                                   ");
            WriteLiteral(@" <div class=""single-hover-banner__content"">
                                        <h4 class=""small-text"">Best Selling !</h4>
                                        <h3 class=""big-text"">Living Room Up To 70% Off</h3>
                                        <a class=""banner-link"" href=""shop-left-sidebar.html"">SHOP NOW</a>
                                    </div>
                                </div>
                            </div>-->
                            <!--=======  End of single hover banner  =======-->
                        <!--</div>
                    </div>
                </div>-->
                <!--=======  End of banner hover wrapper  =======-->
            <!--</div>
        </div>
    </div>
</div>-->
<!--====================  End of banner hover area  ====================-->

<!--====================  feature logo area ====================-->
<div class=""feature-logo-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg");
            WriteLiteral(@"-12"">
                <!--=======  feature logo wrapper  =======-->
                <div class=""feature-logo-wrapper section-space--inner-bottom"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <!--=======  single feature logo  =======-->
                            <div class=""single-feature-logo"">
                                <div class=""single-feature-logo__image"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "77105dd039b30416e21972a8b15cc888c31119059732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""single-feature-logo__content"">
                                    <h4 class=""title"">ارسال رایگان</h4>
                                    <p class=""short-desc"">
                                        ارسال رایگان در اعضای خرید بالای 200 هزار تومان
                                    </p>
                                </div>
                            </div>
                            <!--=======  End of single feature logo  =======-->
                        </div>
                        <div class=""col-md-4"">
                            <!--=======  single feature logo  =======-->
                            <div class=""single-feature-logo"">
                                <div class=""single-feature-logo__image"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "77105dd039b30416e21972a8b15cc888c311190511804", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""single-feature-logo__content"">
                                    <h4 class=""title"">ضمانت بازگشت وجه</h4>
                                    <p class=""short-desc"">
                                        در صورت هرگونه نارضایتی از محصولات وجه شما بازگرداده خواهد شد.
                                    </p>
                                </div>
                            </div>
                            <!--=======  End of single feature logo  =======-->
                        </div>
                        <div class=""col-md-4"">
                            <!--=======  single feature logo  =======-->
                            <div class=""single-feature-logo"">
                                <div class=""single-feature-logo__image"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "77105dd039b30416e21972a8b15cc888c311190513896", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""single-feature-logo__content"">
                                    <h4 class=""title"">پشتیبانی 24/7</h4>
                                    <p class=""short-desc"">
                                        دوستان پشتیبان ما به صورت 24 ساعته در 7 روز هفته خدمات می دهند.
                                    </p>
                                </div>
                            </div>
                            <!--=======  End of single feature logo  =======-->
                        </div>
                    </div>
                </div>
                <!--=======  End of feature logo wrapper  =======-->
            </div>
        </div>
    </div>
</div>
<!--====================  End of feature logo area  ====================-->
");
#nullable restore
#line 128 "D:\Shayan\ASP.NET 5\Project\LampShade_Project\LampShade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArticles"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--====================  newsletter area ====================-->
<!--<div class=""newsletter-area section-space--inner"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 offset-lg-2"">
                <div class=""newsletter-wrapper"">
                    <p class=""small-text"">Special Ofers For Subscribers</p>
                    <h3 class=""title"">Ten Percent Member Discount</h3>
                    <p class=""short-desc"">
                        Subscribe to our newsletters now and stay up to date with new collections,
                        the latest lookbooks and exclusive offers.
                    </p>

                    <div class=""newsletter-form"">
                        <form id=""mc-form"" class=""mc-form"">
                            <input type=""email"" placeholder=""Enter Your Email Address Here..."" required>
                            <button type=""submit"" value=""submit"">SUBSCRIBE</button>
                        </form>

                 ");
            WriteLiteral(@"   </div>-->
                    <!-- mailchimp-alerts Start -->
                    <!--<div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div>--><!-- mailchimp-submitting end -->
                        <!--<div class=""mailchimp-success""></div>--><!-- mailchimp-success end -->
                        <!--<div class=""mailchimp-error""></div>--><!-- mailchimp-error end -->
                    <!--</div>-->
                    <!-- mailchimp-alerts end -->
                <!--</div>
            </div>
        </div>
    </div>
</div>-->
<!--====================  End of newsletter area  ====================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
