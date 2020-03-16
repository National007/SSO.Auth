#pragma checksum "E:\学习备份\OpenAuth.Core\OpenAuth.Mvc\Views\FlowSchemes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20cebcc1138318e9e76cd62be2cd8688c61e64c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlowSchemes_Index), @"mvc.1.0.view", @"/Views/FlowSchemes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FlowSchemes/Index.cshtml", typeof(AspNetCore.Views_FlowSchemes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20cebcc1138318e9e76cd62be2cd8688c61e64c1", @"/Views/FlowSchemes/Index.cshtml")]
    public class Views_FlowSchemes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("header", async() => {
                BeginContext(17, 57, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"/css/treetable.css\" />\n");
                EndContext();
            }
            );
            BeginContext(76, 1588, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote news_search toolList"" id=""menus"">
</blockquote>

<div class=""layui-row"">
    <div class=""layui-col-xs2"">
        <ul id=""tree"" class=""ztree""
            style=""padding: 2px; border: 1px solid #ddd; overflow: auto;"">
        </ul>
     </div>
    <div class=""layui-col-xs10"">
        <table class=""layui-table""
               lay-data=""{height: 'full-80', page:true, id:'mainList'}""
               lay-filter=""list"" lay-size=""sm"">
            <thead>
            <tr>
                <th lay-data=""{checkbox:true, fixed: true}""></th>
                <th lay-data=""{field:'Id', width:150}"">主键Id</th>
                <th lay-data=""{field:'SchemeCode', width:150}"">流程编号</th>
                <th lay-data=""{field:'SchemeName', width:150}"">流程名称</th>
                <th lay-data=""{field:'SchemeVersion', width:150}"">流程版本</th>
                <th lay-data=""{field:'SortCode', width:150}"">排序码</th>
                <th lay-data=""{field:'Disabled', width:150}"">有效</th>
                <th lay-data=");
            WriteLiteral(@"""{field:'Description', width:150}"">备注</th>
                <th lay-data=""{field:'CreateDate', width:150}"">创建时间</th>

                <th lay-data=""{fixed: 'right', width:160, align:'center', toolbar: '#barList'}""></th>
            </tr>
            </thead>
        </table>
    </div>
</div>

<script type=""text/html"" id=""barList"">
    <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""detail"">查看</a>
</script>

<script type=""text/javascript"" src=""/layui/layui.js""></script>
<script type=""text/javascript"" src=""/userJs/flowSchemes.js?v2""></script>


");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
