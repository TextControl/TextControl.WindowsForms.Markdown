using Markdig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx_markup
{
    public static class TextControlExtensions
    {
        public static void LoadMarkdown(this TXTextControl.TextControl textControl, string markdown)
        {
            textControl.Load(ParseMarkdown(markdown), TXTextControl.StringStreamType.HTMLFormat);
        }

        private static string ParseMarkdown(string markdownInput)
        {
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdown.ToHtml(markdownInput, pipeline);
        }
    }
}
