#pragma checksum "E:\学习备份\OpenAuth.Core\OpenAuth.Mvc\Views\FlowInstances\Wait.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd7cf8e79cfae12a651529265a05e36da300f545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlowInstances_Wait), @"mvc.1.0.view", @"/Views/FlowInstances/Wait.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FlowInstances/Wait.cshtml", typeof(AspNetCore.Views_FlowInstances_Wait))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd7cf8e79cfae12a651529265a05e36da300f545", @"/Views/FlowInstances/Wait.cshtml")]
    public class Views_FlowInstances_Wait : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(76, 2108, true);
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
                <th lay-data=""{field:'IsFinish', width:150, templet:'#IsFinish'}"">流程状态</th>
                <th lay-data=""{field:'CustomName', width:150}"">实例名称</th>
                <th lay-data=""{field:'Code', width:150}"">实例编号</th>
                <th lay-data=""{field:'ActivityName', width:150}"">当前节点名称</th>
                <th lay-data=""{field:'CreateDate', width:150}"">创建时间</th>
         ");
            WriteLiteral(@"       <th lay-data=""{field:'CreateUserName', width:150}"">创建用户</th>
                <th lay-data=""{field:'Description', width:150}"">实例备注</th>
                <th lay-data=""{fixed: 'right', width:160, align:'center', toolbar: '#barList'}""></th>
            </tr>
            </thead>
        </table>
    
        <script type=""text/html"" id=""IsFinish"">
            {{# if(d.IsFinish == 0){ }}
            <span class=""layui-badge layui-bg-blue"">正在运行</span>
            {{# } else if(d.IsFinish == 3){ }}
            <span class=""layui-badge"">不同意</span>
            {{# } else if(d.IsFinish == 4){ }}
            <span class=""layui-badge layui-bg-gray"">被驳回</span>
            {{# } else{}}
            <span class=""layui-badge layui-bg-green"">审批通过</span>
            {{# } }}
        </script>
    </div>
</div>

<script type=""text/html"" id=""barList"">
    <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""detail"">查看</a>
</script>

<script type=""text/javascript"" src=""/layui/layui.js""></script>
<script type=""tex");
            WriteLiteral("t/javascript\" src=\"/userJs/flowInstanceWait.js\"></script>\n\n\n");
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
