#pragma checksum "E:\学习备份\OpenAuth.Core\OpenAuth.Mvc\Views\OrgManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66a1a6f66a08b2f5aed7b590ae504b09d900b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrgManager_Index), @"mvc.1.0.view", @"/Views/OrgManager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrgManager/Index.cshtml", typeof(AspNetCore.Views_OrgManager_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66a1a6f66a08b2f5aed7b590ae504b09d900b49", @"/Views/OrgManager/Index.cshtml")]
    public class Views_OrgManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(76, 3116, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote news_search toolList"" id =""menus"">
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
                <th lay-data=""{field:'Name', width:150, sort: true, fixed: true}"">组织名称</th>
                <th lay-data=""{field:'CascadeId', width:150}"">层级ID</th>
                <th lay-data=""{field:'ParentName', width:135}"">父节点名称</th>
                <th lay-data=""{field:'SortNo', width:180}"">排序号</th>
                <th lay-data=""{field:'Id', width:180}"">ID</th>
                <th lay-data=""{fixed: 'right', width:160, align:'center', toolbar: '#b");
            WriteLiteral(@"arList'}""></th>
            </tr>
            </thead>
        </table>
    </div>
</div>

<!--列表右边的按钮-->
<script type=""text/html"" id=""barList"">
    <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""detail"">查看</a>
</script>

<!--用户添加/编辑窗口-->
<div id=""divEdit"" style=""display: none"">
    <form class=""layui-form layui-form-pane"" action="""" id=""formEdit"">

        <input type=""hidden"" name=""Id"" v-model=""Id"" />

        <div class=""layui-form-item"">
            <label class=""layui-form-label"">部门名称</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Name"" v-model=""Name"" required lay-verify=""required""
                       placeholder=""请输入部门名称"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">排序号</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""SortNo"" v-model=""SortNo"" required lay-verify=""required""
               ");
            WriteLiteral(@"        placeholder=""请输入排序号"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item"">
            <label class=""layui-form-label"">所属部门</label>
            <div class=""layui-input-block"">
                <input id=""ParentName"" name=""ParentName"" v-model=""ParentName"" class=""layui-input"" />
                <input id=""ParentId"" name=""ParentId"" v-model=""ParentId""  type=""hidden"" />
                <div id=""menuContent"" class=""menuContent"" style=""display: none;"">
                    <ul id=""org"" class=""ztree""></ul>
                </div>
            </div>
        </div>

        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <button class=""layui-btn"" lay-submit lay-filter=""formSubmit"">立即提交</button>
                <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
            </div>
        </div>
    </form>
</div>

<script type=""text/javascript"" src=""/layui/layui.js""></script>
<script type=""text/jav");
            WriteLiteral("ascript\" src=\"/userJs/orgs.js?v=1\"></script>");
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
