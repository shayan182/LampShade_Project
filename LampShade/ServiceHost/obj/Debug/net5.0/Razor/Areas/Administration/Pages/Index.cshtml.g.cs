#pragma checksum "D:\Shayan\ASP.NET 5\10-Project-Shop-ProductCategory\Code\LampShade\ServiceHost\Areas\Administration\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b12ab20215f8123497c19444ab305cbaefa7f054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Areas_Administration_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/Administration/Pages/Index.cshtml")]
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
#line 1 "D:\Shayan\ASP.NET 5\10-Project-Shop-ProductCategory\Code\LampShade\ServiceHost\Areas\Administration\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12ab20215f8123497c19444ab305cbaefa7f054", @"/Areas/Administration/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    public class Areas_Administration_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("todo-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("todo-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-t-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Shayan\ASP.NET 5\10-Project-Shop-ProductCategory\Code\LampShade\ServiceHost\Areas\Administration\Pages\Index.cshtml"
  
    ViewData["Title"] = "صفحه اصلی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page-Title -->
<div class=""row"">
    <div class=""col-sm-12"">
        <h4 class=""pull-left page-title"">Welcome !</h4>
        <ol class=""breadcrumb pull-right"">
            <li><a href=""#"">Moltran</a></li>
            <li class=""active"">Dashboard</li>
        </ol>
    </div>
</div>

<!-- Start Widget -->
<div class=""row"">
    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-info""><i class=""ion-social-usd""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">15852</span>
                Total Sales
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Sales <span class=""pull-right"">60%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-info"" role=""progressbar"" aria-va");
            WriteLiteral(@"luenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;"">
                            <span class=""sr-only"">60% Complete</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-purple""><i class=""ion-ios7-cart""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">956</span>
                New Orders
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Orders <span class=""pull-right"">90%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-purple"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 90%;");
            WriteLiteral(@""">
                            <span class=""sr-only"">90% Complete</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-success""><i class=""ion-eye""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">20544</span>
                Unique Visitors
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Visitors <span class=""pull-right"">60%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;"">
                            <span class=""sr-only"">60% Com");
            WriteLiteral(@"plete</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-primary""><i class=""ion-android-contacts""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">5210</span>
                New Users
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Users <span class=""pull-right"">57%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-primary"" role=""progressbar"" aria-valuenow=""57"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 57%;"">
                            <span class=""sr-only"">57% Complete</span>
                        </div>
            ");
            WriteLiteral(@"        </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End row-->


<div class=""row"">
    <div class=""col-lg-8"">
        <div class=""portlet"">
            <!-- /portlet heading -->
            <div class=""portlet-heading"">
                <h3 class=""portlet-title text-dark text-uppercase"">
                    Website Stats
                </h3>
                <div class=""portlet-widgets"">
                    <a href=""javascript:;"" data-toggle=""reload""><i class=""ion-refresh""></i></a>
                    <span class=""divider""></span>
                    <a data-toggle=""collapse"" data-parent=""#accordion1"" href=""#portlet1""><i class=""ion-minus-round""></i></a>
                    <span class=""divider""></span>
                    <a href=""#"" data-toggle=""remove""><i class=""ion-close-round""></i></a>
                </div>
                <div class=""clearfix""></div>
            </div>
            <div id=""portlet1"" class=""panel-collapse collapse in"">
");
            WriteLiteral(@"                <div class=""portlet-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div id=""website-stats"" style=""position: relative;height: 320px;""></div>
                            <div class=""row text-center m-t-30"">
                                <div class=""col-sm-4"">
                                    <h4 class=""counter"">86,956</h4>
                                    <small class=""text-muted""> Weekly Report</small>
                                </div>
                                <div class=""col-sm-4"">
                                    <h4 class=""counter"">86,69</h4>
                                    <small class=""text-muted"">Monthly Report</small>
                                </div>
                                <div class=""col-sm-4"">
                                    <h4 class=""counter"">948,16</h4>
                                    <small class=""text-muted"">Yearly Report</small>
             ");
            WriteLiteral(@"                   </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div> <!-- /Portlet -->
    </div> <!-- end col -->

    <div class=""col-lg-4"">
        <div class=""portlet"">
            <!-- /portlet heading -->
            <div class=""portlet-heading"">
                <h3 class=""portlet-title text-dark text-uppercase"">
                    Website Stats
                </h3>
                <div class=""portlet-widgets"">
                    <a href=""javascript:;"" data-toggle=""reload""><i class=""ion-refresh""></i></a>
                    <span class=""divider""></span>
                    <a data-toggle=""collapse"" data-parent=""#accordion1"" href=""#portlet2""><i class=""ion-minus-round""></i></a>
                    <span class=""divider""></span>
                    <a href=""#"" data-toggle=""remove""><i class=""ion-close-round""></i></a>
                </div>
                <div class=""clearfix"">");
            WriteLiteral(@"</div>
            </div>
            <div id=""portlet2"" class=""panel-collapse collapse in"">
                <div class=""portlet-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div id=""pie-chart"">
                                <div id=""pie-chart-container"" class=""flot-chart"" style=""height: 320px;"">
                                </div>
                            </div>

                            <div class=""row text-center m-t-30"">
                                <div class=""col-sm-6"">
                                    <h4 class=""counter"">86,956</h4>
                                    <small class=""text-muted""> Weekly Report</small>
                                </div>
                                <div class=""col-sm-6"">
                                    <h4 class=""counter"">86,69</h4>
                                    <small class=""text-muted"">Monthly Report</small>
                                </d");
            WriteLiteral(@"iv>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div> <!-- /Portlet -->
    </div> <!-- end col -->
</div> <!-- End row -->


<div class=""row"">
    <!-- INBOX -->
    <div class=""col-lg-4"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h4 class=""panel-title"">Inbox</h4>
            </div>
            <div class=""panel-body"">
                <div class=""inbox-widget nicescroll mx-box"">
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-1.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 9057, "\"", 9063, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Chadengle</p>
                            <p class=""inbox-item-text"">Hey! there I'm available...</p>
                            <p class=""inbox-item-date"">13:40 PM</p>
                        </div>
                    </a>
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-2.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 9555, "\"", 9561, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Tomaslau</p>
                            <p class=""inbox-item-text"">I've finished it! See you so...</p>
                            <p class=""inbox-item-date"">13:34 PM</p>
                        </div>
                    </a>
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-3.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 10056, "\"", 10062, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Stillnotdavid</p>
                            <p class=""inbox-item-text"">This theme is awesome!</p>
                            <p class=""inbox-item-date"">13:17 PM</p>
                        </div>
                    </a>
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-4.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 10553, "\"", 10559, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Kurafire</p>
                            <p class=""inbox-item-text"">Nice to meet you</p>
                            <p class=""inbox-item-date"">12:20 PM</p>
                        </div>
                    </a>
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-5.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 11039, "\"", 11045, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Shahedk</p>
                            <p class=""inbox-item-text"">Hey! there I'm available...</p>
                            <p class=""inbox-item-date"">10:15 AM</p>
                        </div>
                    </a>
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-6.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 11535, "\"", 11541, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Adhamdannaway</p>
                            <p class=""inbox-item-text"">This theme is awesome!</p>
                            <p class=""inbox-item-date"">9:56 AM</p>
                        </div>
                    </a>
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-8.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 12031, "\"", 12037, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Arashasghari</p>
                            <p class=""inbox-item-text"">Hey! there I'm available...</p>
                            <p class=""inbox-item-date"">10:15 AM</p>
                        </div>
                    </a>
                    <a href=""#"">
                        <div class=""inbox-item"">
                            <div class=""inbox-item-img""><img src=""images/users/avatar-9.jpg"" class=""img-circle""");
            BeginWriteAttribute("alt", " alt=\"", 12532, "\"", 12538, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <p class=""inbox-item-author"">Joshaustin</p>
                            <p class=""inbox-item-text"">I've finished it! See you so...</p>
                            <p class=""inbox-item-date"">9:56 AM</p>
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </div> <!-- end col -->
    <!-- CHAT -->
    <div class=""col-lg-4"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Chat</h3>
            </div>
            <div class=""panel-body"">
                <div class=""chat-conversation"">
                    <ul class=""conversation-list nicescroll"">
                        <li class=""clearfix"">
                            <div class=""chat-avatar"">
                                <img src=""images/avatar-1.jpg"" alt=""male"">
                                <i>10:00</i>
                            </div>
                       ");
            WriteLiteral(@"     <div class=""conversation-text"">
                                <div class=""ctext-wrap"">
                                    <i>John Deo</i>
                                    <p>
                                        Hello!
                                    </p>
                                </div>
                            </div>
                        </li>
                        <li class=""clearfix odd"">
                            <div class=""chat-avatar"">
                                <img src=""images/users/avatar-5.jpg"" alt=""Female"">
                                <i>10:01</i>
                            </div>
                            <div class=""conversation-text"">
                                <div class=""ctext-wrap"">
                                    <i>Smith</i>
                                    <p>
                                        Hi, How are you? What about our next meeting?
                                    </p>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                        </li>
                        <li class=""clearfix"">
                            <div class=""chat-avatar"">
                                <img src=""images/avatar-1.jpg"" alt=""male"">
                                <i>10:01</i>
                            </div>
                            <div class=""conversation-text"">
                                <div class=""ctext-wrap"">
                                    <i>John Deo</i>
                                    <p>
                                        Yeah everything is fine
                                    </p>
                                </div>
                            </div>
                        </li>
                        <li class=""clearfix odd"">
                            <div class=""chat-avatar"">
                                <img src=""images/users/avatar-5.jpg"" alt=""male"">
                                <i>10:02</i>
                      ");
            WriteLiteral(@"      </div>
                            <div class=""conversation-text"">
                                <div class=""ctext-wrap"">
                                    <i>Smith</i>
                                    <p>
                                        Wow that's great
                                    </p>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <div class=""row"">
                        <div class=""col-sm-9 chat-inputbar"">
                            <input type=""text"" class=""form-control chat-input"" placeholder=""Enter your text"">
                        </div>
                        <div class=""col-sm-3 chat-send"">
                            <button type=""submit"" class=""btn btn-info btn-block waves-effect waves-light"">Send</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end col");
            WriteLiteral(@"-->
    <!-- TODO -->
    <div class=""col-lg-4"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Todo</h3>
            </div>
            <div class=""panel-body todoapp"">
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h4 id=""todo-message""><span id=""todo-remaining""></span> of <span id=""todo-total""></span> remaining</h4>
                    </div>
                    <div class=""col-sm-6"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 17194, "\"", 17201, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""pull-right btn btn-primary btn-sm waves-effect waves-light"" id=""btn-archive"">Archive</a>
                    </div>
                </div>

                <ul class=""list-group no-margn nicescroll todo-list"" style=""max-height: 288px;"" id=""todo-list""></ul>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12ab20215f8123497c19444ab305cbaefa7f05424347", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-9 todo-inputbar"">
                            <input type=""text"" id=""todo-input-text"" name=""todo-input-text"" class=""form-control"" placeholder=""Add new todo"">
                        </div>
                        <div class=""col-sm-3 todo-send"">
                            <button class=""btn-primary btn-block btn waves-effect waves-light"" type=""button"" id=""todo-btn-submit"">Add</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div> <!-- end col -->\r\n</div> <!-- end row -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Areas.Administration.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Administration.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Administration.Pages.IndexModel>)PageContext?.ViewData;
        public ServiceHost.Areas.Administration.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
