﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("speakersId", Attributes = ForAttributeName)]

    public class SpeakersIdTagHelper : TagHelper
    {
        private readonly ISpeakerService speakerService;
        private const string ForAttributeName = "asp-for";
       [HtmlAttributeName(ForAttributeName)]
         public ModelExpression For { get; set; }
      public SpeakersIdTagHelper(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSpeakers = speakerService.GetAllSpeakers();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);
         output.Attributes.Add("class", "form-control");

            foreach (var speaker in allSpeakers)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", speaker.Id.ToString());
                myOption.InnerHtml.Append(speaker.Name);
                output.Content.AppendHtml(myOption);
            }

        }
    }
}
