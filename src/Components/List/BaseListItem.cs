using Microsoft.AspNetCore.Components;

namespace Wangkanai.Blazor
{
    public class BaseListItem
    {
        [Parameter] public string Href { get; set; }

        [Parameter] public bool Disable
        {
            get => disable;
            set { disable = value; }
        }

        private bool disable;
    }
}