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
    
    
    public partial class PeopleSearchResults {
        
        public static implicit operator global::System.Web.UI.TemplateControl(PeopleSearchResults target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::SPLIn.WebParts.PeopleSearchResults @__ctrl) {
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            @__w.Write("\r\n\r\n<script type=\"text/javascript\">\r\n    function getPeopleSearchResultCount() {\r" +
                    "\n        return \"count=");
              @__w.Write( ResultCount );

            @__w.Write(@""";
    }

    function showPeopleSearchResults(result) {
        if (result.people._total == 0) {
            return;
        }

        var dataIds = [];
        for (var index in result.people.values) {
            profile = result.people.values[index]
            dataIds.push(profile.id);
        }
        var profHTML =
            '<script type=""IN/MemberData"" data-ids=""' + dataIds.join("","") + '"" data-fields=""");
                                                                                    @__w.Write( DataFields );

            @__w.Write("\">\' +\r\n            \'<?js var i=0; ?>\' +\r\n            \'<?js for (var member in $(\"" +
                    "*\")) { ?>\' +\r\n            \'    <div class=\"psrch-<?js if(i == 0) { ?>First<?js }" +
                    " ?>FullResult\">\' +\r\n    \t    \'        <div id=\"UserPhoto\">\' +\r\n    \t    \'       " +
                    "     <a href=\"<?js= $(member).siteStandardProfileRequest.url ?>\" title=\"<?js= $(" +
                    "member).formattedName ?>\">\' +\r\n    \t\t\'                <img src=\"<?js if($(member" +
                    ").pictureUrl) { ?><?js= $(member).pictureUrl ?><?js } else { ?>/_layouts/images/" +
                    "o14_person_placeholder_96.png<?js } ?>\" alt=\"<?js= $(member).formattedName ?>\" b" +
                    "order=\"0\" width=\"86\" height=\"86\">\' +\r\n    \t    \'            </a>\' +\r\n           " +
                    " \'        </div>\' +\r\n            \'    </div>\' +\r\n            \'    <span id=\"JBea" +
                    "n\">\' +\r\n            \'    </span>\' +\r\n            \'    <div id=\"ContactInfo\">\' +\r" +
                    "\n    \t    \'        <ul id=\"MiniContactCard\">\' +\r\n    \t\t\'            <li id=\"Name" +
                    "Field\">\' +\r\n    \t\t\'\t            <a href=\"<?js= $(member).siteStandardProfileRequ" +
                    "est.url ?>\"><?js= $(member).formattedName ?></a>\' +\r\n    \t\t\'            </li>\' +" +
                    "\r\n            \'            <li>\' +\r\n            \'                <?js if($(membe" +
                    "r).distance == 1) { ?>1st degree contact<?js } ?>\' +\r\n            \'             " +
                    "   <?js if($(member).distance == 2) { ?>2nd degree contact<?js } ?>\' +\r\n        " +
                    "    \'                <?js if($(member).distance == 3) { ?>3rd degree contact<?js" +
                    " } ?>\' +\r\n            \'                <?js if($(member).distance == -1) { ?>Out" +
                    " of network<?js } ?>\' +\r\n            \'                <?js if($(member).distance" +
                    " == 100) { ?>Group in common<?js } ?>\' +\r\n            \'            </li>\' +\r\n   " +
                    " \t\t\'            <li><?js= $(member).headline ?></li>\' +\r\n    \t\t\'            <li>" +
                    "<?js= $(member).location.name ?></li>\' +\r\n    \t\t\'            <li><?js= $(member)" +
                    ".industry ?></li>\' +\r\n            \'            <?js if($(member).phoneNumbers &&" +
                    " $(member).phoneNumbers.values) { ?>\' +\r\n            \'                <?js for (" +
                    "var i = 0; i < $(member).phoneNumbers.values.length; i++) { ?>\' +\r\n            \'" +
                    "                    <?js var phone = $(member).phoneNumbers.values[i]; ?>\' +\r\n  " +
                    "          \'                    <li><?js= phone.phoneType ?>: <?js= phone.phoneNu" +
                    "mber ?></li>\' +\r\n            \'                <?js } ?>\' +\r\n            \'       " +
                    "     <?js } ?>\' +\r\n    \t\t\'            <li><?js= $(member).numConnections ?><?js " +
                    "if($(member).numConnectionsCapped) { ?>+<?js } ?> connections</li>\' +\r\n    \t    " +
                    "\'        </ul>\' +\r\n    \t    \'        <ul id=\"Actions\">\' +\r\n    \t\t\'            <l" +
                    "i>\' +\r\n    \t\t\'\t            <a href=\"#\">Send message</a>\' +\r\n    \t\t\'            <" +
                    "/li>\' +\r\n            \'            <?js if($(member).distance != 0 && $(member).d" +
                    "istance != 1) { ?>\' +\r\n    \t\t\'            <li>\' +\r\n    \t\t\'\t            <a href=\"" +
                    "#\">Invite to connect</a>\' +\r\n    \t\t\'            </li>\' +\r\n            \'         " +
                    "   <?js } ?>\' +\r\n    \t    \'        </ul>\' +\r\n            \'    </div>\' +\r\n       " +
                    "     \'    <div id=\"MoreInfo\">\' +\r\n            \'        <ul>\' +\r\n            \'   " +
                    "         <?js if($(member).summary) { ?>\' +\r\n            \'                <li>\' " +
                    "+\r\n            \'                    <span id=\"FieldTitle\">Summary</span>\' +\r\n   " +
                    "         \'                    <?js= $(member).summary.replace(/\\n/g, \"<br />\") ?" +
                    ">\' +\r\n            \'                </li>\' +\r\n            \'            <?js } ?>\'" +
                    " +\r\n            \'            <?js if($(member).specialties) { ?>\' +\r\n           " +
                    " \'                <li>\' +\r\n            \'                    <span id=\"FieldTitle" +
                    "\">Specialties</span>\' +\r\n            \'                    <?js= $(member).specia" +
                    "lties.replace(/\\n/g, \"<br />\") ?>\' +\r\n            \'                </li>\' +\r\n   " +
                    "         \'            <?js } ?>\' +\r\n            \'        </ul>\' +\r\n            \'" +
                    "    </div>\' +\r\n            \'    <div id=\"Clear\">\' +\r\n    \t    \'        <img src=" +
                    "\"/_layouts/images/blank.gif\" alt=\"\"/>\' +\r\n            \'    </div>\' +\r\n          " +
                    "  \'    <?js i++; ?>\' +\r\n            \'<?js } ?>\' +\r\n            \'<\\/script>\';\r\n\r\n" +
                    "        $(\"#SPLInSearchResults\").html(profHTML);\r\n        IN.parse();\r\n        $" +
                    "(\"#SPLInSearchResults span:first-child\").removeAttr(\"style\");\r\n    }\r\n</script>\r" +
                    "\n\r\n<script type=\"IN/Login\" data-onAuth=\"loadPeopleSearchData\"></script>\r\n<div cl" +
                    "ass=\"psrch-Main\">\r\n    <div id=\"SPLInSearchResults\" class=\"psrch-results\">\r\n    " +
                    "    <span class=\"ms-descriptiontext\">No results are available.</span>\r\n    </div" +
                    ">\r\n</div>");
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
