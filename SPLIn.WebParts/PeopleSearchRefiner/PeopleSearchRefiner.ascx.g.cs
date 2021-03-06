﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPLIn.WebParts {
    using System.Web;
    using System.Text.RegularExpressions;
    using Microsoft.SharePoint.WebPartPages;
    using Microsoft.SharePoint.WebControls;
    using System.Web.Security;
    using Microsoft.SharePoint.Utilities;
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using Microsoft.SharePoint;
    using System.Web.UI;
    using System.Web.Profile;
    using System.Text;
    using System.Web.Caching;
    using System.Web.UI.WebControls;
    using System.Configuration;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.SessionState;
    using System.Web.UI.HtmlControls;
    
    
    public partial class PeopleSearchRefiner {
        
        public static implicit operator global::System.Web.UI.TemplateControl(PeopleSearchRefiner target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::SPLIn.WebParts.PeopleSearchRefiner @__ctrl) {
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            @__w.Write("\r\n\r\n<script type=\"text/javascript\">\r\n    function showPeopleSearchRefiners(result" +
                    ") {\r\n        var facetsHTML = \"\";\r\n        for (var facetIndex in result.facets." +
                    "values) {\r\n            var facet = result.facets.values[facetIndex];\r\n          " +
                    "  facetsHTML += \'     <div class=\"ms-searchref-categoryname\">\' + facet.name + \'<" +
                    "/div>\';\r\n            facetsHTML += \'     <ul class=\"ms-searchref-filters\">\';\r\n  " +
                    "          var hasRefiner = false;\r\n            var bucketsHTML = \"\";\r\n          " +
                    "  for (var bucketIndex in facet.buckets.values) {\r\n                var bucket = " +
                    "facet.buckets.values[bucketIndex];\r\n                hasRefiner = hasRefiner || b" +
                    "ucket.selected;\r\n                bucketsHTML += \'    <li class=\"ms-searchref-fil" +
                    "ter ms-searchref-\' + (bucket.selected ? \'selected\' : \'unselected\') + \'\">\';\r\n    " +
                    "            bucketsHTML += \'        <a class=\"ms-searchref-filterlink\" title=\"Re" +
                    "fine By: \' + bucket.name + \'\" href=javascript:loadPeopleSearchData(\"\' + facet.co" +
                    "de + \'\",\"\' + bucket.code + \'\")>\' + bucket.name + \'</a>\';\r\n                bucket" +
                    "sHTML += \'        <span class=\"ms-searchref-count\">(\' + bucket.count + \')</span>" +
                    "\';\r\n                bucketsHTML += \'    </li>\';\r\n            }\r\n            face" +
                    "tsHTML += \'         <li class=\"ms-searchref-filter ms-searchref-\' + (!hasRefiner" +
                    " ? \'selected\' : \'unselected\') + \'\">\';\r\n            facetsHTML += \'             <" +
                    "a class=\"ms-searchref-filterlink\" title=\"Refine By:\" href=javascript:loadPeopleS" +
                    "earchData()> Any \' + facet.name + \'</a>\';\r\n            facetsHTML += \'         <" +
                    "/li>\';\r\n            facetsHTML += bucketsHTML;\r\n            facetsHTML += \'     " +
                    "</ul>\';\r\n            facetsHTML += \'     <div class=\"ms-searchref-catseparator\">" +
                    " </div>\';\r\n        }\r\n\r\n        $(\"#SPLInPeopleRefiners\").html(facetsHTML);\r\n   " +
                    " }\r\n\r\n    function getPeopleSearchRefinerFields() {\r\n        return \"facets:(");
                @__w.Write( RefinerFields );

            @__w.Write(")\";\r\n    }\r\n\r\n    function getPeopleSearchRefiners() {\r\n        return \"facets=");
               @__w.Write( Refiners );

            @__w.Write(@""";
    }
</script>

<div id=""SPLInPeopleRefiners"" class=""srch-WPBody ms-searchref-main"">
    <div class=""ms-searchref-categoryname""></div>
    <ul class=""ms-searchref-filters"">
        <li class=""ms-searchref-filtermsg"">
            <span class=""ms-searchref-filterlink ms-searchref-msg"">No refinements available</span>
        </li>
    </ul>
</div>");
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
