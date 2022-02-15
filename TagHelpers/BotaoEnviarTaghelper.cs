using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjetoTreino0702.TagHelpers
{
    public class BotaoEnviarTaghelper : TagHelper
    {
        public string Texto { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.Attributes.SetAttribute("type", "submit");
            if (string.IsNullOrEmpty(Texto))
            {
                output.Attributes.SetAttribute("value", "Cadastrar");
            }
            else
                output.Attributes.SetAttribute("value", Texto);
            output.Attributes.SetAttribute("class", "btn btn-success");
        }
    }
}
