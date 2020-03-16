#pragma checksum "E:\学习备份\OpenAuth.Core\OpenAuth.Mvc\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "875c79079fc8f8df25b28d75413c9fd93c3edd04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"875c79079fc8f8df25b28d75413c9fd93c3edd04", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(76, 1033, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote news_search toolList"" id=""menus"">
</blockquote>

<div style=""display: flex;"">
    <ul id=""tree"" class=""ztree"" style=""display: inline-block; width: 180px; padding: 10px; border: 1px solid #ddd; overflow: auto;""></ul>
    <table class=""layui-table""
           lay-data=""{height: 'full-80', page:true, id:'mainList'}""
           lay-filter=""list""  lay-size=""sm"">
        <thead>
            <tr>
                <th lay-data=""{checkbox:true, fixed: true}""></th>
                <th lay-data=""{field:'Id', width:180}"">ID</th>
                <th lay-data=""{field:'Name', width:180}"">类型名称</th>
                <th lay-data=""{field:'TypeId', width:180}"">类型分类</th>
                <th lay-data=""{field:'TypeName', width:180}"">类型分类</th>
                <th lay-data=""{field:'Description', width:180}"">描述</th>
                <th lay-data=""{fixed: 'right', width:160, align:'center', toolbar: '#barList'}""></th>
            </tr>
        </thead>
    </table>
</div>
<script type=""text/html"" id=""b");
            WriteLiteral("arList\">\n");
            EndContext();
            BeginContext(1195, 2329, true);
            WriteLiteral(@"    <a class=""layui-btn layui-btn-xs"" lay-event=""edit"">编辑</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del"">删除</a>
</script>

<!--用户添加/编辑窗口-->
<div id=""divEdit"" style=""display: none"">
    <form class=""layui-form layui-form-pane"" action="""" id=""formEdit"">

        <div class=""layui-form-item"">
            <label class=""layui-form-label"">类型标识</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Id"" v-model=""Id"" required lay-verify=""required""
                       placeholder=""请输入类型标识"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">名称</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Name"" v-model=""Name"" required lay-verify=""required""
                       placeholder=""请输入名称"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item"">
           ");
            WriteLiteral(@" <label class=""layui-form-label"">类型分类</label>
            <div class=""layui-input-block"">
                <input id=""TypeName"" name=""TypeName"" v-model=""TypeName"" required lay-verify=""required"" class=""layui-input"" />
                <input id=""TypeId"" name=""TypeId"" v-model=""TypeId"" required lay-verify=""required"" type=""hidden"" />
                <div id=""menuContent"" class=""menuContent"" style=""display: none;"">
                    <ul id=""org"" class=""ztree""></ul>
                </div>
            </div>
        </div>
        
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">描述</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Description"" v-model=""Description""
                       placeholder=""请输入描述"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <button class=""layui-btn"" lay-submit lay-filter=""formSubmit"">立即提");
            WriteLiteral(@"交</button>
                <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
            </div>
        </div>
    </form>
</div>

<script type=""text/javascript"" src=""/layui/layui.js""></script>
<script type=""text/javascript"" src=""/userJs/categories.js""></script>");
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
